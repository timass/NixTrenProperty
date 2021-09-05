﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core;
using NixTrenProperty.Models;

namespace NixTrenProperty.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        // public DbSet<Rieltor> Rieltors { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        // public DbSet<BuyerOrSeekerRieltor> BuyerOrSeekerRieltor { get; set; }

        //  public DbSet<SalesFigure> SalesFigures { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Statistic> Statistic { get; set; }
        public DbSet<Plot> Plots { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<ParkingPlace> ParkingPlaces { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ManyLevelsApartment> ManyLevelsApartments { get; set; }
        public DbSet<RoomIndividual> RoomIndividuals { get; set; }
        public DbSet<RoomInFlat> RoomInFlats { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}


