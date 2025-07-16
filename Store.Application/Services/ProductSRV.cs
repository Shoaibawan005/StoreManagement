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
    public class ProductSRV : IProductSRV
    {
        private readonly IProductRepo _productRepo;

        public ProductSRV(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public List<Product> GetAllProducts()
        {
            var products = _productRepo.GetAllProducts();

            return products;
        }

        public Product AddProduct(ProductModel productModel)
        {
            if (string.IsNullOrEmpty(productModel.Name) || string.IsNullOrEmpty(productModel.Description) || decimal.IsNegative(productModel.Price))
            {
                throw new ArgumentException();
            }

            var product = _productRepo.AddProduct(productModel);

            return product;

        }

        public string DeleteProduct(int id)
        {
            var msg = _productRepo.DeleteProduct(id);

            return msg;
        }
    }
}
