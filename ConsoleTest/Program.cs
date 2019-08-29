using DAL.Model;
using System;
using System.Data.Entity;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new HotelContext())
            {
                foreach (var checkIn in db.CheckIns.Include(c=>c.Room.Hotel.City.Country).Include(c=>c.Guests))
                {
                    Console.WriteLine("Information about checkIn:");
                    Console.Write($"{checkIn.Room?.RoomNumber} -" +
                        $" {checkIn.Room?.Hotel?.Name} - " +
                        $"{checkIn.Room?.Hotel?.City?.Name} - " +
                        $" {checkIn.Room?.Hotel?.City?.Country?.Name}\n");
                    Console.WriteLine("Information about guests:");
                    foreach (var guest in checkIn?.Guests)
                    {
                        Console.Write($"{guest?.FirstName} -" +
                        $" {guest?.LastName}\n");
                    }
                    Console.WriteLine(new string('*', 70));
                }
            }
            Console.ReadKey();
        }
    }
}
