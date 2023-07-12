using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CartDAO
    {
        // Singleton Pattern
        private CartDAO() { }
        private static CartDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CartDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CartDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Cart> GetAllCartItems()
        {
            try
            {
                using(var context = new HommieStoreContext())
                {
                    return context.Carts.Include(c => c.Product).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Save(Cart cart)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {

                    Cart c = context.Carts.SingleOrDefault(o => o.Username == cart.Username && o.ProductId == cart.ProductId) as Cart;
                        
                    if (c != null)
                    {
                        c.LastUpdatedTime = DateTime.Now;
                        c.Quantity++;
                    }
                    else
                    {
                        cart.LastUpdatedTime = DateTime.Now;
                        context.Carts.Add(cart);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateCartQuantityById(int id, int quantity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    Cart cart = context.Carts.Find(id);
                    cart.LastUpdatedTime = DateTime.Now;
                    cart.Quantity = quantity;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCartById(int id)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    Cart cart = context.Carts.SingleOrDefault(c => c.Id == id);
                    context.Carts.Remove(cart);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
