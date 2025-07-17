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
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        { 
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            var products = _context.Products.ToList();

            return products;

        }

        public Product AddProduct(ProductModel productModel)
        {
            var product = new Product
            {
                Name = productModel.Name,
                Description = productModel.Description,
                Price = productModel.Price
            };
            _context.Products.Add(product);
            _context.SaveChanges();

            return product;

        }

        public string DeleteProduct(int id)
        {

            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) {
                return "Product Doesn't Exist.";
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return "Product Deleted Successfully.";

        }


    }
}
