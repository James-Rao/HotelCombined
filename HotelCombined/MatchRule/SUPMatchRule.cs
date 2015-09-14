using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelCombined.MatchRule
{
    class SUPMatchRule : IMatchRule
    {
        public bool IsMatch(SupplierHotel supplierHotel, Hotel hotel)
        {
            string newHotelName = FilterPunctuation(supplierHotel.Name);
            string newAddress = FilterPunctuation(supplierHotel.Address);

            if (newHotelName == hotel.Name && newAddress == hotel.Address)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string FilterPunctuation(string source)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in source)
            {
                if (char.IsPunctuation(item))
                {
                    sb.Append("");
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
    }
}
