using HotelCombined.MatchRule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelCombined
{
    public class HotelMatcherSample : IHotelMatcher
    {
        private static readonly string _assemblyName = "HotelCombined";
        private static readonly string _namespaceName = "MatchRule";
        private static readonly string _reflectionSuffix = "MatchRule";

        public bool IsMatch(SupplierHotel supplierHotel, Hotel hotel)
        {
            IMatchRule matchRule = GetMatchRule(supplierHotel);

            return matchRule.IsMatch(supplierHotel, hotel);
        }

        IMatchRule GetMatchRule(SupplierHotel supplierHotel)
        {
            string className = _assemblyName + "." + _namespaceName + "." + supplierHotel.SupplierCode.ToUpper() + _reflectionSuffix;
            IMatchRule matchRule = (IMatchRule)Assembly.Load(_assemblyName).CreateInstance(className);
            return matchRule;
        }
    }

}
