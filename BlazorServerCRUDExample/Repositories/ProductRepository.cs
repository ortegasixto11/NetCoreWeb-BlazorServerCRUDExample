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

        public async Task AddAsync(Product product)
        {
            _context.BlazorServerCRUD_Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
            _context.BlazorServerCRUD_Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            _context.BlazorServerCRUD_Products.Remove(await _context.BlazorServerCRUD_Products.Where(x => x.ID == id).FirstOrDefaultAsync());
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.BlazorServerCRUD_Products.ToListAsync();
        }

        public async Task<Product> GetAsync(Guid id)
        {
            return await _context.BlazorServerCRUD_Products.Where(x => x.ID == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.BlazorServerCRUD_Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
