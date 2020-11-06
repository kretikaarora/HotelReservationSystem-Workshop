using System;

namespace HotelManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hotel Reservation System");
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.CreatingListOfHotels();
        }
    }
}
