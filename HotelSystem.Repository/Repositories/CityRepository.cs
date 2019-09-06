using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;
using System.Data.Entity;

namespace HotelSystem.Repository
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(DbContext context) 
            : base(context)
        {

        }
    }
}
