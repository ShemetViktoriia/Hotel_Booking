using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Model
{
    class HotelContextInitializer : DropCreateDatabaseAlways<HotelContext>
    {
        protected override void Seed(HotelContext context)
        {
            var listCheckIns = new List<CheckIn>
            {
                new CheckIn
                {
                    Room = new Room
                    {
                        RoomNumber = 101,
                        Hotel = new Hotel
                        {
                            Name = "The Nadler Kensington",
                            City = new City {Name = "Marseille", Country = new Country {Name = "Germany"} },
                            StarRating = 5,
                            NumberOfFloors = 5,
                            IsRestraunt = true
                        },
                        NumberOfRooms = 2,
                        MaxNumberOfGuests = 5,
                        HasVipStatus = true,
                        CostPerDay = 250
                    },
                    DateArrival = new DateTime(2019,9,10),
                    DateDepartureExpected = new DateTime(2019,9,18),
                    DateDepartureReal = null,
                    RestaurantBill =null,
                    Guests = new List<Guest>
                    {
                        new Guest
                        {
                            FirstName = "Viktoriia",
                            LastName = "Shemet",
                            IsMale = false,
                            DOB = new DateTime(1984,8,31),
                            Discont = null,
                            HasVipStatus = true,
                            Passport = "AM102536"
                        },
                        new Guest
                        {
                            FirstName = "Nadiia",
                            LastName = "Shemet",
                            IsMale = false,
                            DOB = new DateTime(2006,8,12),
                            Discont = null,
                            HasVipStatus = true,
                            Passport = null
                        }
                    }
                },
                new CheckIn
                {
                    Room = new Room
                    {
                        RoomNumber =1001,
                        Hotel = new Hotel
                        {
                            Name = "Park Grand Lancaster Gate",
                            City =  new City {Name = "Sun City", Country = new Country{Name = "Brazil"} },
                            StarRating =3,
                            NumberOfFloors = 2,
                            IsRestraunt = false
                        },
                        NumberOfRooms = 1,
                        MaxNumberOfGuests = 2,
                        HasVipStatus = false,
                        CostPerDay = 100
                    },
                    DateArrival = new DateTime(2019,9,5),
                    DateDepartureExpected = new DateTime(2019,9,10),
                    DateDepartureReal = null,
                    RestaurantBill =null,
                    Guests = new List<Guest>
                    {
                        new Guest
                        {
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            IsMale = true,
                            DOB = new DateTime(1964,10,25),
                            Discont = null,
                            HasVipStatus = false,
                            Passport = "FE955774"
                        }    
                    }
                }
            };
            context.CheckIns.AddRange(listCheckIns);
            context.SaveChanges();
        }
    }
}
