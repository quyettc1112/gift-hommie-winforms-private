using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
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

        public double GetTotalOfOrder(int id)
        {
            Order order = Get(id);
            if (order == null)
                return 0;
            double res = order.ShippingFee.Value;

            if (order.OrderDetails != null)
            {
                foreach (OrderDetail detail in order.OrderDetails)
                    res += detail.Price.Value * detail.Quantity.Value;
            }

            return res;
        }

        public List<Order> GetOrdersWithStatus(List<string> status) => GetAll()
                                    .Where(o => status.Contains(o.Status)).ToList();

        private int GetOrderedProductQuantity(int id)
        {
            List<string> statusList = new List<string> { "PENDING", "DELIVERY", "SUCCESSFUL", "CONFIRMED" };
            List<Order> list = GetOrdersWithStatus(statusList);
            int orderedQuantity = 0;

            foreach (Order order in list)
            {
                foreach (OrderDetail detail in order.OrderDetails)
                {
                    if (detail.ProductId == id)
                        orderedQuantity += (int)detail.Quantity;
                }
            }

            return orderedQuantity;
        }

        public int GetAvailableProductQuantity(int id) => (ProductDAO.Instance.Get(id)).Quantity - GetOrderedProductQuantity(id);

        public List<OrderDetail> GetOrderDetails(int id) => OrderDAO.Instance.GetOrderDetails(id);
        private double GetRevenueFromTo(DateTime start, DateTime end)
        {
            end = end.AddDays(1);
            List<string> statusList = new List<string>
            {
                "SUCCESSFUL"
            };
            List<Order> list = GetOrdersWithStatus(statusList).Where(o => start <= o.OrderTime
                                                            && o.OrderTime <= end).ToList();
            
            double revenue = 0;

            foreach (var order in list)
            {
                revenue += (double)order.OrderDetails.Sum(od => od.Quantity * od.Price);
            }

            return revenue;
        }

        public double GetRevenueByDay(DateTime date) => GetRevenueFromTo(date, date);

        public double GetRevenueByMonth(DateTime date)
        {
            DateTime start = date;
            int month = date.Month;
            DateTime end = date;

            while (start.Month == month)
            {
                if (start.AddDays(-1).Month != month)
                {
                    break;
                }
                start = start.AddDays(-1);
            }
            while (end.Month == month)
            {
                if (end.AddDays(1).Month != month)
                {
                    break;
                }
                end = end.AddDays(1);
            }

            return GetRevenueFromTo(start, end);
        }

        public double GetRevenueByWeek(DateTime date)
        {
            DateTime start = date;
            DateTime end = date;

            while (start.DayOfWeek != DayOfWeek.Monday) 
            { 
                start = start.AddDays(-1);
            }
            while (end.DayOfWeek != DayOfWeek.Sunday) 
            { 
                end = end.AddDays(1);
            }
            
            return GetRevenueFromTo(start, end);
        }

        private int GetTotalOrderFromTo(DateTime start, DateTime end)
        {
            end = end.AddDays(1);
            List<Order> orders = GetAll().Where(o => start <= o.OrderTime
                                                            && o.OrderTime <= end).ToList();
            return GetAll().Where(o => start <= o.OrderTime
                                                            && o.OrderTime <= end).Count();
        }

        public int GetTotalOrderByDay(DateTime date) => GetTotalOrderFromTo(date, date);
        public int GetTotalOrderByWeek(DateTime date)
        {
            DateTime start = date;
            int month = date.Month;
            DateTime end = date;

            while (start.Month == month)
            {
                if (start.AddDays(-1).Month != month)
                {
                    break;
                }
                start = start.AddDays(-1);
            }
            while (end.Month == month)
            {
                if (end.AddDays(1).Month != month)
                {
                    break;
                }
                end = end.AddDays(1);
            }
            return GetTotalOrderFromTo(start, end);
        }
        public int GetTotalOrderByMonth(DateTime date)
        {
            DateTime start = date;
            int month = date.Month;
            DateTime end = date;

            while (start.Month == month)
            {
                if (start.AddDays(-1).Month != month)
                {
                    break;
                }
                start = start.AddDays(-1);
            }
            while (end.Month == month)
            {
                if (end.AddDays(1).Month != month)
                {
                    break;
                }
                end = end.AddDays(1);
            }

            return GetTotalOrderFromTo(start, end);
        }
    }
}
