using System.Collections.Generic;

namespace DAL.Model
{
    /// <summary>
    /// Keeps countries where hotels are registered
    /// </summary>
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
