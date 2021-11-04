using OrderManagement.Bussiness.Abstract;
using OrderManagement.DataAccess.Abstract;
using OrderManagement.DataAccess.Concrete;
using OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Bussiness.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Order CreateOrder(Order order)
        {
            return _orderRepository.CreateOrder(order);
        }

        public List<OrderDetail> CreateOrderDetail(OrderDetail orderDetail)
        {
            return _orderRepository.CreateOrderDetail(orderDetail);
        }

        public void DeleteOrder(int orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }

        public void DeleteOrderDetail(int orderDetailId)
        {
            _orderRepository.DeleteOrderDetail(orderDetailId);
        }

        public List<OrderDetail> GetAllOrderDetail(int orderId)
        {
            return _orderRepository.GetAllOrderDetail(orderId);
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderById(int orderId)
        {
            return _orderRepository.GetOrderById(orderId);
        }

        public Order UpdateOrder(Order order)
        {
            return _orderRepository.UpdateOrder(order);
        }

        public OrderDetail UpdateOrderDetail(OrderDetail orderDetail)
        {
            return _orderRepository.UpdateOrderDetail(orderDetail);
        }
    }
}
