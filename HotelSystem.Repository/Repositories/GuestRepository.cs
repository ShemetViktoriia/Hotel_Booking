using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;

namespace HotelSystem.Repository
{
    public class GuestRepository : BaseRepository<Guest>, IGuestRepository
    {
        public GuestRepository(HotelContext context) 
            : base(context)
        {

        }
    }
}
