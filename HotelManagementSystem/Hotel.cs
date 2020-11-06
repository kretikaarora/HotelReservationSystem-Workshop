using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    public class Hotel
    {
        public string hotelName;
        public int weekdayRateForRegularCustomer;

        public Hotel(string hotelName,int weekdayRateForRegularCustomer)
        {
            this.hotelName = hotelName;
            this.weekdayRateForRegularCustomer=weekdayRateForRegularCustomer;
        }
    }
}
