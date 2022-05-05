using System.Collections.Generic;

namespace EMA.Models
{
    public static class SumCalculator
    {
        public static string CalculateSumCart(List<CartItem> items)
        {
            var calculatedSum = 0d;

            foreach (var cartItem in items)
            {
                calculatedSum += cartItem.Sum();
            }

            return calculatedSum.ToString("0.00 €");
        }
    }
}
