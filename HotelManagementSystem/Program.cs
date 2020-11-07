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
            Console.WriteLine(" ");
            Console.WriteLine("Please enter your CustomerType ie. Regular or Rewards");
            string customerType = Console.ReadLine();
            Console.WriteLine("Please enter the date for your stay at our hotel");
            string dates = Console.ReadLine();
            hotelReservation.CreatingListOfHotels(customerType);

            ///splitting dates and storing them in an array
            string[] arrayOfDates = dates.Split(',');
            List<DayOfWeek> listOfDates = new List<DayOfWeek>();

            ///adding days into a list 
            foreach (string date in arrayOfDates)
            {
                DateTime dateTime = Convert.ToDateTime(date);
                listOfDates.Add(dateTime.DayOfWeek);
            }
            //hotelReservation.FindingTheCheapestHotel(listOfDates);
            //hotelReservation.BestRatedHotelForGivenDateRange(listOfDates, customerType);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("select the option below");
                Console.WriteLine("Select 1 To find the cheapest Hotel ");
                Console.WriteLine("Select 2 To find the Best Rated Cheapest hotel");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        hotelReservation.FindingTheCheapestHotel(listOfDates, customerType);                       
                        break;
                    case 2:
                        hotelReservation.BestRatedHotelForGivenDateRange(listOfDates, customerType);
                        break;
                    default:
                        Console.WriteLine("Option not valid");
                        break;
                }
                Console.WriteLine("Do you wish to select again Press Y ");
                char character = Convert.ToChar(Console.ReadLine());
                if (!(character.Equals('Y')))
                {
                    break;
                }
            }
        }
    }
}