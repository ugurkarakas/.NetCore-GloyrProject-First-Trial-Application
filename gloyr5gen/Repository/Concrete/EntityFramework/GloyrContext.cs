using gloyr5gen.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Concrete.EntityFramework
{
    public class GloyrContext : DbContext
    {
        public GloyrContext(DbContextOptions<GloyrContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<ulke> ulkes { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<CalismaSekli> CalismaSeklis { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<AdvertisementCategory>()
          .HasKey(pk => new { pk.AdvertisementId, pk.CategoryId });
        }
    }
}
