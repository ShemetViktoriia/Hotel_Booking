using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Range (1, 5, ErrorMessage = "Star rating must be beetwen 1 and 5")]
        public int StarRating { get; set; }
        [Range (1, 10, ErrorMessage = "Number of floors must be beetwen 1 and 10")]
        public int NumberOfFloors { get; set; }
        public bool IsRestraunt { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
