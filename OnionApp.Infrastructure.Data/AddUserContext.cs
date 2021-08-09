using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core;

namespace OnionApp.Infrastructure.Data
{
    class AddUserContext<U> : DbContext
        
    {
        public DbSet<User> Users { get; set; }
    }
}
