using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;
using System.Data.Entity;

namespace HotelSystem.Repository
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(DbContext context) 
            : base(context)
        {

        }
    }
}
