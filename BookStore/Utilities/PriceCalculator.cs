using System;

namespace BookStore.Common.Utilities
{
    public class PriceCalculator
    {
        public static decimal CalculateNetByGrossAndVat(decimal gross, int vat)
        {
            if (gross <= 0 || vat <= 0)
                return 0;

            var calculatedVat = (decimal)((vat + 100) * 0.01);

            return Math.Round(gross / calculatedVat, 2);
        }

        public static decimal CalculateGrossByNetAndVat(decimal net, int vat)
        {
            if (net <= 0 || vat <= 0)
                return 0;

            return Math.Round(net + (net * (vat * 0.01m)), 2);
        }

        public static int CalculateVatByGrossAndNet(decimal gross, decimal net)
        {
            if (gross <= 0 || net <= 0)
                return 0;

            var vat = (gross - net) / net;

            return (int)(Math.Round(vat / 0.01m));
        }
    }
}
