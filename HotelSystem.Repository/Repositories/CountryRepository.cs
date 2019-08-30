using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;

namespace HotelSystem.Repository
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(HotelContext context) 
            : base(context)
        {

        }
    }
}
