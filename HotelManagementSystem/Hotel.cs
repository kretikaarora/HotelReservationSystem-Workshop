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
        public int weekendRateForRegularCustomer;
        public int totalPrice;

        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="hotelName"></param>
        /// <param name="weekdayRateForRegularCustomer"></param>
        public Hotel(string hotelName,int weekdayRateForRegularCustomer,int weekendRateForRegularCustomer )
        {
            this.hotelName = hotelName;
            this.weekdayRateForRegularCustomer=weekdayRateForRegularCustomer;
            this.weekendRateForRegularCustomer = weekendRateForRegularCustomer;
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
