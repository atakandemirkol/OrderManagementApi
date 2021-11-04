using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Bussiness.Abstract;
using OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private IOrderService _orderService;
        public OrderDetailController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("{orderId}")]
        public List<OrderDetail> GetOrderDetailList(int orderId)
        {
            var res = _orderService.GetAllOrderDetail(orderId);
            return res;
        }
        [HttpPost]
        public List<OrderDetail> AddOrderDetail([FromBody] OrderDetail orderDetail)
        {
            return _orderService.CreateOrderDetail(orderDetail);
        }
        [HttpPut]
        public OrderDetail UpdateOrderDetail([FromBody] OrderDetail orderDetail)
        {
            return _orderService.UpdateOrderDetail(orderDetail);
        }
        [HttpDelete("{id}")]
        public void DeleteOrderDetail(int id)
        {
            _orderService.DeleteOrderDetail(id);
        }
    }
}
