using HW_1_30_03_21.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_1_30_03_21.DataContext
{
    public class ShopDBContext : DbContext
    {
        public ShopDBContext(DbContextOptions options) : base(options)
        {
        }

        protected ShopDBContext()
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
