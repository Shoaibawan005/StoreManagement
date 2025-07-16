using Store.Domain.Entities;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.IRepositries
{
    public interface IProductRepo
    {
        public List<Product> GetAllProducts();

        public Product AddProduct(ProductModel productModel);

        public string DeleteProduct(int id);
    }
}
