using System;
using System.Collections.Generic;

namespace DAL.Model
{
    /// <summary>
    /// Keeps all checkIns in hotel system
    /// </summary>
    public partial class CheckIn
    {
        public Room Room { get; set; }
        public DateTime DateArrival { get; set; }
        public DateTime DateDepartureExpected { get; set; }
        public DateTime? DateDepartureReal { get; set; }
        public decimal? RestaurantBill { get; set; }
        public ICollection<Guest> Guests { get; set; }
    }
}
