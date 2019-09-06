using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;
using System.Data.Entity;

namespace HotelSystem.Repository
{
    public class GuestRepository : BaseRepository<Guest>, IGuestRepository
    {
        public GuestRepository(DbContext context) 
            : base(context)
        {

        }
    }
}
