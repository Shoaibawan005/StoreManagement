using Store.Application.IServices;
using Store.Domain.Entities;
using Store.Domain.Models;
using Store.Infrastructure.IRepositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services
{
    public class OrderSRV : IOrderSRV
    {
        private readonly IOrderRepo _orderRepo;

        public OrderSRV(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public List<Order> GetAllOrders()
        {
            var orders = _orderRepo.GetAllOrders();

            return orders;
        }

        public Order? AddOrder(OrderModel orderModel)
        {
            if (int.IsNegative(orderModel.ProductId) || int.IsNegative(orderModel.UserId))
                return null;

            var order = _orderRepo.AddOrder(orderModel);

            return order;

        }

        public string DeleteOrder(int id)
        {
            var msg = _orderRepo.DeleteOrder(id);

            return msg;
        }
    }
}
