using OrderManagement.DataAccess.Abstract;
using OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.DataAccess.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        public Order CreateOrder(Order order)
        {
            using (var masterDB = new OrderDBContext())
            {
                masterDB.Order.Add(order);
                masterDB.SaveChanges();
                return order;
            }
        }

        public List<OrderDetail> CreateOrderDetail(OrderDetail orderDetail)
        {
            using (var masterDB = new OrderDBContext())
            {
                masterDB.OrderDetail.Add(orderDetail);
                masterDB.SaveChanges();
                var res = masterDB.OrderDetail.Where(e => e.OrderId == orderDetail.OrderId).ToList();
                return res;
            }
        }

        public void DeleteOrder(int orderId)
        {
            using (var masterDB = new OrderDBContext())
            {
                var deletedOrder = GetOrderById(orderId);
                masterDB.Order.Remove(deletedOrder);
                masterDB.SaveChanges();
            }
        }

        public void DeleteOrderDetail(int orderDetailId)
        {
            using (var masterDB = new OrderDBContext())
            {
                var deletedOrder = masterDB.OrderDetail.Find(orderDetailId);
                masterDB.OrderDetail.Remove(deletedOrder);
                masterDB.SaveChanges();
            }
        }

        public List<OrderDetail> GetAllOrderDetail(int orderId)
        {
            using (var masterDB = new OrderDBContext())
            {
                return masterDB.OrderDetail.Where(e => e.OrderId == orderId).ToList();
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var masterDB = new OrderDBContext())
            {
                return masterDB.Order.ToList();
            }
        }

        public Order GetOrderById(int orderId)
        {
            using (var masterDB = new OrderDBContext())
            {
                return masterDB.Order.Find(orderId);
            }
        }

        public Order UpdateOrder(Order order)
        {
            using (var masterDB = new OrderDBContext())
            {
                masterDB.Order.Update(order);
                masterDB.SaveChanges();
                return order;
            }
        }

        public OrderDetail UpdateOrderDetail(OrderDetail orderDetail)
        {
            using (var masterDB = new OrderDBContext())
            {
                masterDB.OrderDetail.Update(orderDetail);
                masterDB.SaveChanges();
                return orderDetail;
            }
        }
    }
}
