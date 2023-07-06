using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        // Singleton Pattern
        private OrderDAO() { }
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        // CRUD
        public List<Order> GetAll()
        {
            List<Order> list = new List<Order>();
            try
            {
                using (var context = new HommieStoreContext())
                {
                    list = context.Orders.Include(item => item.OrderDetails).Include(item => item.User).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public List<Order> GetAllOrdersOfUser(string username)
        {
            List<Order> list = new List<Order>();
            try
            {
                using (var context = new HommieStoreContext())
                {
                    list = context.Orders.Include(item => item.OrderDetails).Include(item => item.User).Where(item => item.Username.ToLower().Equals(username.ToLower())).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public Order Get(int id)
        {
            Order entity = null;
            try
            {
                using (var context = new HommieStoreContext())
                {
                    entity = context.Orders.Include(item => item.OrderDetails).Include(item => item.User).SingleOrDefault<Order>(item => item.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public bool Exist(int id)
        {
            Order entity = null;
            try
            {
                using (var context = new HommieStoreContext())
                {
                    entity = context.Orders.SingleOrDefault<Order>(item => item.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity != null;
        }

        public void Create(Order entity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    if (Instance.Exist(entity.Id))
                    {
                        throw new Exception("Duplicated entity (id).");
                    }

                    context.Orders.Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Order entity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    if (Instance.Exist(entity.Id) == false)
                    {
                        throw new Exception("The entity does not exist: " + entity.Id);
                    }
                    context.Entry<Order>(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + entity.Id);
            }
        }

        public void Save(Order entity)
        {
            try
            {
                if (Instance.Exist(entity.Id))
                    Instance.Update(entity);
                else
                    Instance.Create(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + entity.Id);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    Order entity = Instance.Get(id);
                    if (entity == null)
                    {
                        throw new Exception("Entity is not exist.");
                    }

                    context.Orders.Remove(entity);
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
