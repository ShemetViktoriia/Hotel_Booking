using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;

namespace HotelSystem.Repository
{
    public class HotelRepository : BaseRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(HotelContext context) 
            : base(context)
        {

        }
    }
}
