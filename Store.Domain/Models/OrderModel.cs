using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Models
{
    public class OrderModel
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
