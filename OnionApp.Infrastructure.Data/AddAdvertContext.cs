using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Core;

namespace OnionApp.Infrastructure.Data
{
    public class AddAdvertContext : DbContext
    {
       public DbSet<Apartment> Apartments { get; set; }
    }
}
