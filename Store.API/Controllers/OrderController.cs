using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Store.Infrastructure;
using Store.Domain;
using Store.Application.IServices;
using Store.Domain.Models;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderSRV _iOrderSRV;

        public OrderController(IOrderSRV iOrderSRV) 
        {
            _iOrderSRV = iOrderSRV;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var result = _iOrderSRV.GetAllOrders();

            return Ok(result);
        }

        [HttpPost]

        public IActionResult AddOrder(OrderModel orderModel)
        {
            var result = _iOrderSRV.AddOrder(orderModel);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var result = _iOrderSRV.DeleteOrder(id);

            return Ok(result);
        }
    }
}
