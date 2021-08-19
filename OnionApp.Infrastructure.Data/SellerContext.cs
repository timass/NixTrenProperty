using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core;

namespace OnionApp.Infrastructure.Data
{
   public class SellerContext : DbContext
        
    {
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public SellerContext (DbContextOptions<SellerContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
}
}
