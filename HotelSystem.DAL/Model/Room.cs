using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    /// <summary>
    /// Keeps rooms in hotels
    /// </summary>
    public partial class Room
    {
        public int RoomNumber { get; set; }
        public Hotel Hotel { get; set; }
        [Range(1, 5, ErrorMessage = "Number of rooms must be beetwen 1 and 5")]
        public int NumberOfRooms { get; set; }
        [Range(1, 10, ErrorMessage = "Number of guests must be beetwen 1 and 10")]
        public int MaxNumberOfGuests { get; set; }
        public bool HasVipStatus { get; set; }
        public decimal CostPerDay { get; set; }
        public ICollection<CheckIn> CheckIns { get; set; }
    }
}
