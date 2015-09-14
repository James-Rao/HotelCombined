using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelCombined.MatchRule
{
    interface IMatchRule
    {
        bool IsMatch(SupplierHotel supplierHotel, Hotel hotel);
    }
}
