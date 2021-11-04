using OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Bussiness.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int orderId);
        Order CreateOrder(Order order);
        Order UpdateOrder(Order order);
        void DeleteOrder(int orderId);

        List<OrderDetail> GetAllOrderDetail(int orderId);
        List<OrderDetail> CreateOrderDetail(OrderDetail orderDetail);
        OrderDetail UpdateOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderDetailId);
    }
}
