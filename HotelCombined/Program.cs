using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCombined
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            object o = null;
            try
            {
                int? i = (int?)o;
                int i2 = i ?? 0;
                Console.WriteLine(i2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //
            HotelCombinedTest hct = new HotelCombinedTest();
            hct.Test();

            Console.ReadLine();
        }

    }
}
