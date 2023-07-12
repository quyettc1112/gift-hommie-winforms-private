using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CartRepository : ICartRepository
    {
        private IOrderRepository orderRepository = new OrderRepository();
        public void DeleteCartById(int id) => CartDAO.Instance.DeleteCartById(id);

        public List<Cart> GetAllCartItemsByUsername(string username) => CartDAO.Instance.GetAllCartItems().Where(c => c.Username == username).ToList();

        public Cart GetCartById(string username, int id) => GetAllCartItemsByUsername(username)
                                            .SingleOrDefault(c => c.Id == id);

        public bool RefreshAllCart(string username)
        {
            List<Cart> list = GetAllCartItemsByUsername(username);
            bool isRefresh = false;

            foreach (Cart cart in list)
            {
                int available = orderRepository.GetAvailableProductQuantity((int)cart.ProductId);

                if (cart.Quantity > available)
                {
                    cart.Quantity = available;
                    UpdateCartQuantityById(cart.Id, (int)cart.Quantity);
                    isRefresh = true;
                }
            }
            return isRefresh;
        }

        public void RefreshCart(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Cart cart) => CartDAO.Instance.Save(cart);

        public void UpdateCartQuantityById(int id, int quantity) => CartDAO.Instance.UpdateCartQuantityById(id, quantity);
    }
}
