using DAL.Model;
using HotelSystem.Repository.BaseRepository;
using HotelSystem.Repository.Interfaces;
using System.Data.Entity;

namespace HotelSystem.Repository
{
    public class CheckInRepository : BaseRepository<CheckIn>, ICheckInRepository
    {
        public CheckInRepository(DbContext context) 
            : base(context)
        {

        }
    }
}
