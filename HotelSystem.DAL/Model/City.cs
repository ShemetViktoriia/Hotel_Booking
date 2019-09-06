using System.Collections.Generic;

namespace DAL.Model
{
    /// <summary>
    /// Keeps cities where hotels are registered
    /// </summary>
    public partial class City
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
    }
}
