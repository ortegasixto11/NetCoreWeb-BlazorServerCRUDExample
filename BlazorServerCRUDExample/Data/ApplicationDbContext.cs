using BlazorServerCRUDExample.Models;
using Microsoft.EntityFrameworkCore;
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

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    if (!options.IsConfigured)
        //    {
        //        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DB_CRUD_GraphQL;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    }
        //}

        public virtual DbSet<Product> Products { get; set; }
    }
}
