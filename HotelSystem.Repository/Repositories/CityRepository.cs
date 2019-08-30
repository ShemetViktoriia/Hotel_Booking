using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;

namespace HotelSystem.Repository
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(HotelContext context) 
            : base(context)
        {

        }
    }
}
