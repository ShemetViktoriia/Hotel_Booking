using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;
using System.Data.Entity;

namespace HotelSystem.Repository
{
    public class HotelRepository : BaseRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(DbContext context) 
            : base(context)
        {

        }
    }
}
