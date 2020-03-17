using BlazorServerCRUDExample.Data;
using BlazorServerCRUDExample.Models;
using BlazorServerCRUDExample.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUDExample.Repositories
{
    public class ProductRepository : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            //_context = new ApplicationDbContext();
            _context = context;
        }

        public async Task Add(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            _context.Products.Remove(await _context.Products.Where(x => x.ID == id).FirstOrDefaultAsync());
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> Get()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> Get(Guid id)
        {
            return await _context.Products.Where(x => x.ID == id).FirstOrDefaultAsync();
        }

        public async Task Update(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
