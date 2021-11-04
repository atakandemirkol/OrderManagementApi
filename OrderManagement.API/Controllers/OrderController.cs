using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Bussiness.Abstract;
using OrderManagement.Bussiness.Concrete;
using OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public List<Order> Get()
        {
            var res = _orderService.GetAllOrders();
            return res;
        }
        [HttpGet("{id}")]
        public Order GetById(int id)
        {
            return _orderService.GetOrderById(id);
        }
        [HttpPost]
        public Order Add([FromBody] Order order)
        {
            return _orderService.CreateOrder(order);
        }
        [HttpPut]
        public Order Update([FromBody] Order order)
        {
            return _orderService.UpdateOrder(order);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _orderService.DeleteOrder(id);
        }

    }
}
