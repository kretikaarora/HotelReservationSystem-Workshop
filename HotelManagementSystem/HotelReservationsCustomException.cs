using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    class HotelReservationsCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_CUSTOMERTYPE, INVALID_STAYDATE
        }
        public ExceptionType type;
        public HotelReservationsCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
