using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTest2.Model;
using Microsoft.EntityFrameworkCore;

namespace apiTest2.Model
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}