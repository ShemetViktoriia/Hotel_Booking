using DAL.Model;
using System.Data.Entity.ModelConfiguration;

namespace DAL.ModelConfiguration
{
    public class CountryConfiguration: EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            this.HasIndex(c => c.Name).IsUnique();
            this.Property(c => c.Name).IsRequired().HasMaxLength(20);
        }
    }

    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            this.Property(c => c.Name).IsRequired().HasMaxLength(20);
        }
    }

    public class HotelConfiguration : EntityTypeConfiguration<Hotel>
    {
        public HotelConfiguration()
        {
            this.Property(h => h.Name).IsRequired().HasMaxLength(30);
        }
    }

    public class RoomConfiguration : EntityTypeConfiguration<Room>
    {
        public RoomConfiguration()
        {
            this.Property(r => r.CostPerDay).HasPrecision(10, 2);
        }
    }

    public class GuestConfiguration : EntityTypeConfiguration<Guest>
    {
        public GuestConfiguration()
        {
            this.Property(g => g.FirstName).IsRequired().HasMaxLength(20);
            this.Property(g => g.LastName).IsRequired().HasMaxLength(20);
        }
    }

    public class CheckInConfiguration : EntityTypeConfiguration<CheckIn>
    {
        public CheckInConfiguration()
        {
            this.Property(c => c.RestaurantBill).HasPrecision(10, 2);
        }
    }
}
