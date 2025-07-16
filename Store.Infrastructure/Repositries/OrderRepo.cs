using Store.Domain.Entities;
using Store.Domain.Models;
using Store.Infrastructure.IRepositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repositries
{
    public class OrderRepo : IOrderRepo
    {

       private readonly AppDbContext _context;

        public OrderRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<Order> GetAllOrders()
        {
            var orders = _context.Orders.ToList();
            return orders;
        }

        public Order AddOrder(OrderModel orderModel)
        {
            var order = new Order
            {
                ProductId = orderModel.ProductId,
                UserId = orderModel.UserId,
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;

        }

        public string DeleteOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == id);

            if (order == null) {
                return "Oreder Doesn't Exist.";
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();

            return " Order Deleted Successfully.";
        }

    }
}
