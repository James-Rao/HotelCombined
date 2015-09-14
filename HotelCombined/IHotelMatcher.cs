using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCombined
{
    public interface IHotelMatcher
    {
        bool IsMatch(SupplierHotel supplierHotel, Hotel hotel);
    }

}
