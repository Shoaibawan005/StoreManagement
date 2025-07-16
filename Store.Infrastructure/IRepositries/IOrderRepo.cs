using Store.Domain.Entities;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.IRepositries
{
    public interface IOrderRepo
    {
        public List<Order> GetAllOrders();

        public Order AddOrder(OrderModel orderModel);

        public string DeleteOrder(int id);
    }
}
