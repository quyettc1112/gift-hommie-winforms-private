using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICartRepository
    {
        public void Save(Cart cart);
        public Cart GetCartById(string username, int cartId);
        public void UpdateCartQuantityById(int id, int quantity);
        public List<Cart> GetAllCartItemsByUsername(string username);

        public void DeleteCartById(int id);

        public bool RefreshAllCart(String username);
        public void RefreshCart(int id);

    }
}
