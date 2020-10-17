using BookStore.Common.Enums;
using BookStore.Common.Exceptions;
using BookStore.Common.Utilities;

namespace BookStore.Domain.Entities
{
    public class Stock
    {
        public int Quantity { get; set; }
        public int Vat { get; }
        public decimal WholesalePriceGross { get; set; }
        public decimal RetailPriceGross { get; set; }

        public Stock(int vat)
        {
            if (vat <= 0)
                throw new InvalidVat();

            Vat = vat;
        }

        public void SetPrice(decimal price, PriceType priceType)
        {
            if (price <= 0)
                throw new InvalidPrice();

            if (priceType == PriceType.WholesalePrice)
                WholesalePriceGross = price;

            if (priceType == PriceType.RetailPrice)
                RetailPriceGross = price;
        }

        public decimal WholesalePriceNet 
            => PriceCalculator.CalculateNetByGrossAndVat(WholesalePriceGross, Vat);

        public decimal RetailPriceNet 
            => PriceCalculator.CalculateNetByGrossAndVat(RetailPriceGross, Vat);

        public void SetQuantity(int quantity)
        {
            if (quantity < 0)
                throw new NegativeQuantity();

            Quantity = quantity;
        }
    }
}
