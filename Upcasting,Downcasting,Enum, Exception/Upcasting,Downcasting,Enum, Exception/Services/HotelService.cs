using System;
using System.Collections.Generic;
using System.Text;
using Upcasting_Downcasting_Enum__Exception.Models;

namespace Upcasting_Downcasting_Enum__Exception.Services
{
    public class HotelService
    {
        public void ReserveRoom(Hotel hotel, int? roomId)
        {
            try
            {
                hotel.MakeReservation(roomId);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (Exceptions.NotAvailableException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error:" + ex.Message);
            }
        }
    }
}
