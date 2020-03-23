using BlazorServerCRUDExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUDExample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseNpgsql(GetConnectionString()).Options)
        {
        }

        private static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            return configuration.GetConnectionString("DefaultConnection");
        }

        public virtual DbSet<Product> BlazorServerCRUD_Products { get; set; }
    }
}
