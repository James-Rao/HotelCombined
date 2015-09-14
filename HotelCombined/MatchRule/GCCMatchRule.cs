using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelCombined.MatchRule
{
    class GCCMatchRule : IMatchRule
    {
        public bool IsMatch(SupplierHotel supplierHotel, Hotel hotel)
        {
            string[] names = supplierHotel.Name.Split(new char[] {' '});
            Array.Reverse(names);
            StringBuilder sb = new StringBuilder();
            foreach (var item in names)
            {
                sb.Append(item);
                sb.Append(" ");
            }
            string result = sb.ToString();
            result = result.TrimEnd();

            return (result == hotel.Name) ? true : false;
        }
    }
}
