using Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
    }
}
