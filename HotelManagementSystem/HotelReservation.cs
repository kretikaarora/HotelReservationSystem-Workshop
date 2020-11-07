// --------------------------------------------------------------------------------------------------------------------
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
   public class HotelReservation
    {
        ///list to store hotel name and their price
        List<Hotel> hotelListForRegularCustomer = new List<Hotel>();
        List<Hotel> hotelListForRewardCustomer = new List<Hotel>();
        ///list to compute total price and find the cheapest
        List<Hotel> totalPriceRegularCustomerComparisonList = new List<Hotel>();            

        /// <summary>
        /// Creating a list of hotels
        /// UC1
        /// </summary>
        public void CreatingListOfHotels(string customerType)
        {
            if (customerType.Equals(CustomerType.Regular.ToString()))
            {
                ///adding new hotel name and their price
                hotelListForRegularCustomer.Add(new Hotel("Lakewood", 110, 90, 3));
                hotelListForRegularCustomer.Add(new Hotel("Bridgewood", 150, 50, 4));
                hotelListForRegularCustomer.Add(new Hotel("Ridgewood", 220, 150, 5));
                ///list of hotels
                Console.WriteLine(" ");
                Console.WriteLine("The list of Hotel with Rates For Regular Customer is ");
                foreach (Hotel hotel in hotelListForRegularCustomer)
                {
                    Console.WriteLine("HotelName : " + hotel.hotelName + "  RegularWeekdayRate : " + hotel.weekdayRateForCustomer + "  RegularWeekendRate : " + hotel.weekendRateForCustomer);
                }
            }
            if (customerType.Equals(CustomerType.Rewards.ToString()))
            {
                ///adding new hotel name and their price
                hotelListForRewardCustomer.Add(new Hotel("Lakewood", 80, 80, 3));
                hotelListForRewardCustomer.Add(new Hotel("Bridgewood", 110, 50, 4));
                hotelListForRewardCustomer.Add(new Hotel("Ridgewood", 100, 40, 5));
                ///list of hotels
                Console.WriteLine(" ");
                Console.WriteLine("The list of Hotel with Rates For Reward Customer is ");
                foreach (Hotel hotel in hotelListForRewardCustomer)
                {
                    Console.WriteLine("HotelName : " + hotel.hotelName + "  RegularWeekdayRate : " + hotel.weekdayRateForCustomer + "  RegularWeekendRate : " + hotel.weekendRateForCustomer);
                }
            }


        }

        /// <summary>
        /// calculating total price of hotel for days given
        /// UC2,UC4
        /// </summary>
        /// <param name="daysList"></param>
        public void CalculateTotalPrice(List<DayOfWeek> daysList,string customerType)
        {
            int totalPrice;
            if (customerType.Equals(CustomerType.Regular.ToString()))
            {
                foreach (Hotel hotel in hotelListForRegularCustomer)
                {
                    totalPrice = 0;
                    foreach (DayOfWeek day in daysList)
                    {
                        if (day.ToString().Equals("Saturday") || day.ToString().Equals("Sunday"))
                        {
                            totalPrice = totalPrice + hotel.weekendRateForCustomer;
                        }
                        else
                        {
                            totalPrice = totalPrice + hotel.weekdayRateForCustomer;
                        }
                    }
                    ///adding totalprice and hotelName to list
                    totalPriceRegularCustomerComparisonList.Add(new Hotel(totalPrice, hotel.hotelName, hotel.ratingsForHotel));
                }

            }
            if (customerType.Equals(CustomerType.Rewards.ToString()))
            {
                foreach (Hotel hotel in hotelListForRewardCustomer)
                {
                    totalPrice = 0;
                    foreach (DayOfWeek day in daysList)
                    {
                        if (day.ToString().Equals("Saturday") || day.ToString().Equals("Sunday"))
                        {
                            totalPrice = totalPrice + hotel.weekendRateForCustomer;
                        }
                        else
                        {
                            totalPrice = totalPrice + hotel.weekdayRateForCustomer;
                        }
                    }
                    ///adding totalprice and hotelName to list
                    totalPriceRegularCustomerComparisonList.Add(new Hotel(totalPrice, hotel.hotelName, hotel.ratingsForHotel));
                }
            }
        }

        /// <summary>
        /// Finding The Cheapest Hotel
        /// UC2,UC3(added weekend Price)
        /// </summary>
        /// <param name="daysList"></param>
        public void FindingTheCheapestHotel(List<DayOfWeek> daysList,string customerType)
        {
            ///calling the cal total price function 
            CalculateTotalPrice(daysList,customerType);
            ///ordering in ascending order to find cheapest hotel
            foreach(Hotel hotel in totalPriceRegularCustomerComparisonList.OrderBy(a=>a.totalPrice).ToList())
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
        public void BestRatedHotelForGivenDateRange(List<DayOfWeek> daysList,string customerType)
        {
            CalculateTotalPrice(daysList,customerType);
            ///ordering in descending order and breaking after printing the best rated
            foreach (Hotel hotel in totalPriceRegularCustomerComparisonList.OrderByDescending(a => a.ratingsForHotel).ToList())
            {
                Console.WriteLine(" ");
                Console.WriteLine("BestRated Hotel Name : " + hotel.hotelName + "  Rating : " + hotel.ratingsForHotel + "  Total Price :" + hotel.totalPrice);
                break;
            }

        }
    }
}
