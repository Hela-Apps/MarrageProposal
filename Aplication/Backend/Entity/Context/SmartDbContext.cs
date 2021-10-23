using Entity.Models;
using Microsoft.EntityFrameworkCore;
using SmartERP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Context
{
    public class SmartDbContext : DbContext
    {
        public SmartDbContext(DbContextOptions<SmartDbContext> options) : base(options)
        { }

        public DbSet<Provience> Provience { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<VehicleCategory> VehicleCategory { get; set; }
        public DbSet<VehicleCondition> VehicleCondition { get; set; }
        public DbSet<PriceRange> PriceRange { get; set; }
        public DbSet<VehicleCompany> VehicleCompany { get; set; }
        public DbSet<AdsCategory> AdsCategory { get; set; }
        public DbSet<ManuFacturedYear> ManuFacturedYear { get; set; }
        public DbSet<Transmission> Transmission { get; set; }
        public DbSet<FuelType> FuelType { get; set; }

    }
}
