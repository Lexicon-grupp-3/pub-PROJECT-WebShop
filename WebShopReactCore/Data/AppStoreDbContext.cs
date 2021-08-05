using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebShopReactCore.Models;

namespace WebShopReactCore.Data
{
    public class AppStoreDbContext : DbContext
    {
        public AppStoreDbContext(DbContextOptions<AppStoreDbContext> options) : base(options) 
        {
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
