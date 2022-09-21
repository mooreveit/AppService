using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.Utility
{
   public static  class DecimalToFraction
    {


        public static string DecToStr(decimal value)
        {
            int integral = 0;
            decimal fractional = 0;
            StringBuilder sb = new StringBuilder();
            if (value < 0)
            {
                value *= -1;
                sb.Append('-');
            }
            SplitDecimal(value, out integral, out fractional);
            while (integral > 0)
            {
                sb.Insert(0, integral % 10);
                integral /= 10;
            }
            sb.Append('.');
            while (fractional != 0)
            {
                int temp = 0;
                SplitDecimal(fractional * 10, out temp, out fractional);
                sb.Append(temp);
            }
            return sb.ToString();
        }
        static void SplitDecimal(decimal value, out int integral, out decimal fractional)
        {
            integral = (int)value;
            fractional = value - integral;
        }

    }
}
