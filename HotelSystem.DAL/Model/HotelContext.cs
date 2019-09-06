using DAL.ModelConfiguration;
using DAL.ModelInitializer;
using HotelSystem.DAL.Common;
using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Threading;

namespace DAL.Model
{
    public class HotelContext : DbContext
    {
        static HotelContext()
        {
            Database.SetInitializer(new HotelContextInitializer());
        }

        public HotelContext()
            : base("DbConnection")
        { }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<CheckIn> CheckIns { get; set; }

        // Override the OnModelCreating method to add
        // configuration settings
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new HotelConfiguration());
            modelBuilder.Configurations.Add(new RoomConfiguration());
            modelBuilder.Configurations.Add(new GuestConfiguration());
            modelBuilder.Configurations.Add(new CheckInConfiguration());
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
              .Where(x => x.Entity is IAuditableEntity
                  && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    //TODO later for Web
                    string identityName = new WindowsPrincipal(WindowsIdentity.GetCurrent()).Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }
            return base.SaveChanges();
        }
    }
}
