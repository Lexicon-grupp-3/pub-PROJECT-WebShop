using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebShopReactCore.Data
{
    public class AppStoreDbContext:DbContext
    {
        public AppStoreDbContext(DbContextOptions options) : base(options) { }
    }
}
