using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Interfaces;
using OnionApp.Domain.Core;

namespace OnionApp.Infrastructure.Data
{
    public class AdvertContext<O> : DbContext

    {
       public DbSet<Apartment> Apartments { get; set; }
    }
}
