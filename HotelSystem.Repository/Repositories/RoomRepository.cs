using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;

namespace HotelSystem.Repository
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(HotelContext context) 
            : base(context)
        {

        }
    }
}
