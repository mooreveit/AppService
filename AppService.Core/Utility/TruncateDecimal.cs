using System;

namespace AppService.Core.Utility
{
    public static class TruncateDec
    {
        public static decimal TruncateDecimal(decimal d, int decimals)
        {
            if (decimals < 0)
                throw new ArgumentOutOfRangeException("decimals", "Value must be in range 0-28.");
            else if (decimals > 28)
                throw new ArgumentOutOfRangeException("decimals", "Value must be in range 0-28.");
            else if (decimals == 0)
                return Math.Truncate(d);
            else
            {
                decimal integerPart = Math.Truncate(d);
                decimal scalingFactor = d - integerPart;
                decimal multiplier = (decimal)Math.Pow(10, decimals);

                scalingFactor = Math.Truncate(scalingFactor * multiplier) / multiplier;

                return integerPart + scalingFactor;
            }
        }
    }
}
