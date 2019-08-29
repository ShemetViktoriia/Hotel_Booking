using System;
using System.Collections.Generic;

namespace DAL.Model
{
    /// <summary>
    /// Keeps all guests registered in hotel system
    /// </summary>
    public class Guest
    {
        public int Id { get; set; }
        public string Passport { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public bool IsMale { get; set; }
        public bool HasVipStatus { get; set; }
        public int? Discont { get; set; }
        public ICollection<CheckIn> CheckIns { get; set; }
    }
}
