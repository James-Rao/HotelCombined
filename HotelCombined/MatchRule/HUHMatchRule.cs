using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelCombined.MatchRule
{
    class HUHMatchRule : IMatchRule
    {
        private static readonly decimal Max_Degree = (200 / 111);
        public bool IsMatch(SupplierHotel supplierHotel, Hotel hotel)
        {
            if (supplierHotel.ChainCode.Trim().ToLower() == hotel.ChainCode.Trim().ToLower()
                && ((supplierHotel.Latitude <= hotel.Latitude + Max_Degree && supplierHotel.Latitude >= hotel.Latitude - Max_Degree)
               && (supplierHotel.Longitude <= hotel.Longitude + Max_Degree && supplierHotel.Longitude >= hotel.Longitude - Max_Degree)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
