// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace HotelManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hotel Reservation System");
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.CreatingListOfHotels();

            Console.WriteLine("Please enter the date for your stay at our hotel");
            string dates = Console.ReadLine();
            ///splitting dates and storing them in an array
            string[] arrayOfDates = dates.Split(',');
            List<DayOfWeek> listOfDates = new List<DayOfWeek>();

            ///adding days into a list 
            foreach(string date in arrayOfDates)
            {
                DateTime dateTime= Convert.ToDateTime(date);
                listOfDates.Add(dateTime.DayOfWeek);
            }
            hotelReservation.FindingTheCheapestHotel(listOfDates);
        }
    }
}
