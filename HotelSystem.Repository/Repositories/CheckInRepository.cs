using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;

namespace HotelSystem.Repository
{
    public class CheckInRepository : BaseRepository<CheckIn>, ICheckInRepository
    {
        public CheckInRepository(HotelContext context) 
            : base(context)
        {

        }
    }
}
