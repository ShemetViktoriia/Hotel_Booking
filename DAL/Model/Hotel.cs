using System.Collections.Generic;

namespace DAL.Model
{
    /// <summary>
    /// Keeps hotels in the chain
    /// </summary>
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public int StarRating { get; set; }
        public int NumberOfFloors { get; set; }
        public bool IsRestraunt { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
