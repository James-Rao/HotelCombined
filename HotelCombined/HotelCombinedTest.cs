using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelCombined
{
    class HotelCombinedTest
    {
        private static readonly string matchStr = "\r\n Match \r\n";
        private static readonly string notMatchStr = "\r\n Don't Match \r\n";

        public void Test()
        {
            IHotelMatcher hm = new HotelMatcherSample();

            #region test case for SUP
            {
                SupplierHotel sh = new SupplierHotel() { Name = "*-a&b@c]", Address = "#s%t[r*e@e!t", SupplierCode = "SUP" };
                Hotel h = new Hotel() { Name = "abc", Address = "street" };
                bool b = hm.IsMatch(sh, h);
                string isMatchStr = b == true ? matchStr : notMatchStr;
                Console.WriteLine("----------------SUP--------------\r\n"
                    + sh.Name + ", " + sh.Address 
                    + isMatchStr 
                    + h.Name + ", " + h.Address);
            }
            #endregion

            #region test case for HUH
            {
                SupplierHotel sh = new SupplierHotel() { ChainCode = "123", Latitude = -30, Longitude = 150, SupplierCode = "HUH" };
                Hotel h = new Hotel() { ChainCode = "123", Latitude = -30, Longitude = 149 };
                bool b = hm.IsMatch(sh, h);
                string isMatchStr = b == true ? matchStr : notMatchStr;
                Console.WriteLine("----------------HUH--------------\r\n"
                    + sh.ChainCode + ", " + sh.Latitude + ", " + sh.Longitude 
                    + isMatchStr
                    + h.ChainCode + ", " + h.Latitude + ", " + h.Longitude);
            }
            #endregion

            #region test case for GCC
            {
                SupplierHotel sh = new SupplierHotel() { Name = "abc hotel", SupplierCode = "GCC" };
                Hotel h = new Hotel() { Name = "hotel abc" };
                bool b = hm.IsMatch(sh, h);
                string isMatchStr = b == true ? matchStr : notMatchStr;
                Console.WriteLine("----------------GCC--------------\r\n"
                    + sh.Name 
                    + isMatchStr 
                    + h.Name);
            }
            #endregion
        }
    }
}
