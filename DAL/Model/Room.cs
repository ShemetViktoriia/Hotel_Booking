using System.Collections.Generic;

namespace DAL.Model
{
    /// <summary>
    /// Keeps rooms in hotels
    /// </summary>
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public Hotel Hotel { get; set; }
        public int NumberOfRooms { get; set; }
        public int MaxNumberOfGuests { get; set; }
        public bool HasVipStatus { get; set; }
        public decimal CostPerDay { get; set; }
        public ICollection<CheckIn> CheckIns { get; set; }
    }
}
