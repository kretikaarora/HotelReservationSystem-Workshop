// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HotelReservation.cs" company="Capgemini">
//   Copyright
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    class HotelReservation
    {
        List<Hotel> hotelList = new List<Hotel>();
        public void CreatingListOfHotels()
        {
            hotelList.Add(new Hotel("Lakewood", 110));
            hotelList.Add(new Hotel("Bridgewood", 160));
            hotelList.Add(new Hotel("Ridgewood", 220));
            Console.WriteLine("The list of Hotel with Rates is ");
            foreach(Hotel hotel in hotelList)
            {
                Console.WriteLine("HotelName : "+ hotel.hotelName +"  RegularWeekdayRate : "+ hotel.weekdayRateForRegularCustomer);
            }
        }
    }
}
