using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;

namespace BussinessObjects
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAll() => OrderDAO.Instance.GetAll();

        public void Delete(int id) => OrderDAO.Instance.Delete(id);

        public bool Exist(int id) => OrderDAO.Instance.Exist(id);

        public Order Get(int id) => OrderDAO.Instance.Get(id);

        public void Add(Order entity) => OrderDAO.Instance.Save(entity);

        public void Update(Order entity) => OrderDAO.Instance.Update(entity);

        public void Save(Order entity) => OrderDAO.Instance.Save(entity);

        public List<Order> GetAllOrdersOfCustomer(string username) => OrderDAO.Instance.GetAllOrdersOfUser(username);
    }
}
