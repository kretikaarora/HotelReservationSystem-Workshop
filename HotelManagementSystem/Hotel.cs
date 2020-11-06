// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hotel.cs" company="Capgemini">
//   Copyright
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    /// <summary>
    /// Hotel Class
    /// </summary>
    public class Hotel
    {
        public string hotelName;
        public int weekdayRateForRegularCustomer;
        ///Added under UC2 for calculating total price
        public int totalPrice;
        ///Added under UC3 for weekend rates
        public int weekendRateForRegularCustomer;
        ///Added under UC5 for checking Ratings
        public int ratingsForHotel;
        
        

        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="hotelName"></param>
        /// <param name="weekdayRateForRegularCustomer"></param>
        public Hotel(string hotelName,int weekdayRateForRegularCustomer,int weekendRateForRegularCustomer,int ratingsForHotel )
        {
            this.hotelName = hotelName;
            this.weekdayRateForRegularCustomer=weekdayRateForRegularCustomer;
            this.weekendRateForRegularCustomer = weekendRateForRegularCustomer;
            this.ratingsForHotel = ratingsForHotel;
        }

        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="totalPrice"></param>
        /// <param name="hotelName"></param>
        public Hotel(int totalPrice,string hotelName)
        {
            this.hotelName = hotelName;
            this.totalPrice = totalPrice;
        }
    }
}
