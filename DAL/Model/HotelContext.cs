using System.Data.Entity;

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
    }
}
