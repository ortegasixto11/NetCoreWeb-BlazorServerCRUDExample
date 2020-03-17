using BlazorServerCRUDExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUDExample.Services
{
    public interface IProductService
    {
        Task<List<Product>> Get();
        Task<Product> Get(Guid id);
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Guid id);
    }
}
