﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HotelReservation.cs" company="Capgemini">
//   Copyright
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagementSystem
{
    /// <summary>
    /// Hotel Reservation
    /// </summary>
    class HotelReservation
    {
        ///list to store hotel name and their price
        List<Hotel> hotelList = new List<Hotel>();
        ///list to compute total price and find the cheapest
        List<Hotel> totalPriceForComparisonList = new List<Hotel>();

        /// <summary>
        /// Creating a list of hotels
        /// UC1
        /// </summary>
        public void CreatingListOfHotels()
        {
            ///adding new hotel name and their price
            hotelList.Add(new Hotel("Lakewood", 110,90,3));
            hotelList.Add(new Hotel("Bridgewood", 150,50,4));
            hotelList.Add(new Hotel("Ridgewood", 220,150,5));
            ///list of hotels
            Console.WriteLine(" ");
            Console.WriteLine("The list of Hotel with Rates is ");
            foreach(Hotel hotel in hotelList)
            {
                Console.WriteLine("HotelName : "+ hotel.hotelName +"  RegularWeekdayRate : "+ hotel.weekdayRateForRegularCustomer+"  RegularWeekendRate : "+hotel.weekendRateForRegularCustomer);
            }
        }

        /// <summary>
        /// calculating total price of hotel for days given
        /// UC2,UC4
        /// </summary>
        /// <param name="daysList"></param>
        public void CalculateTotalPrice(List<DayOfWeek> daysList)
        {
            int totalPrice;           
            foreach (Hotel hotel in hotelList)
            {
                totalPrice = 0;
                foreach (DayOfWeek day in daysList)
                {    
                    if(day.ToString().Equals("Saturday")|| day.ToString().Equals("Sunday"))
                    {
                        totalPrice = totalPrice + hotel.weekendRateForRegularCustomer;
                    }
                    else
                    {
                        totalPrice = totalPrice + hotel.weekdayRateForRegularCustomer;
                    }                   
                }              
                ///adding totalprice and hotelName to list
                totalPriceForComparisonList.Add(new Hotel(totalPrice, hotel.hotelName,hotel.ratingsForHotel));
            }
            
        }

        /// <summary>
        /// Finding The Cheapest Hotel
        /// UC2,UC3(added weekend Price)
        /// </summary>
        /// <param name="daysList"></param>
        public void FindingTheCheapestHotel(List<DayOfWeek> daysList)
        {
            ///calling the cal total price function 
            CalculateTotalPrice(daysList);
            ///ordering in ascending order to find cheapest hotel
            foreach(Hotel hotel in totalPriceForComparisonList.OrderBy(a=>a.totalPrice).ToList())
            {
                ///breaking after showing the top entry in list()
                Console.WriteLine(" ");
                Console.WriteLine("Cheapest Hotel Name : "+ hotel.hotelName +"  Rating : "+hotel.ratingsForHotel+"  Total Price :" +hotel.totalPrice);
                break;
            }
        }

        /// <summary>
        /// Best Rated Hotel For Given DateRange
        /// UC7
        /// </summary>
        /// <param name="daysList"></param>
        public void BestRatedHotelForGivenDateRange(List<DayOfWeek> daysList)
        {
            CalculateTotalPrice(daysList);
            ///ordering in descending order and breaking after printing the best rated
            foreach (Hotel hotel in totalPriceForComparisonList.OrderByDescending(a => a.ratingsForHotel).ToList())
            {
                Console.WriteLine(" ");
                Console.WriteLine("BestRated Hotel Name : " + hotel.hotelName + "  Rating : " + hotel.ratingsForHotel + "  Total Price :" + hotel.totalPrice);
                break;
            }

        }
    }
}
