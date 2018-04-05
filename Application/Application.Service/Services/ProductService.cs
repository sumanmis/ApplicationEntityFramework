using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;


namespace Application.Service.Services
{
    public class ProductService : IProductService
    {
        private ProductsEntities db = new ProductsEntities();
        public Product GetProduct(int id)
        {
            return db.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
    }
}