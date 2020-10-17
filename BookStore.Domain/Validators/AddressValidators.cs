using BookStore.Common.Exceptions;
using BookStore.Common.Extensions;
using System.Text.RegularExpressions;

namespace BookStore.Domain.Validators
{
    public class AddressValidators
    {
        public static void ValidCity(string city)
        {
            if (city.IsNotExist())
                throw new MissingCity();
        }

        public static void ValidStreet(string street)
        {
            if (street.IsNotExist())
                throw new MissingStreet();
        }

        public static void ValidPostcode(string postCode)
        {
            if (postCode.IsNotExist())
                throw new MissingPostcode();

            if (!Regex.IsMatch(postCode, @"\d{2}-\d{3}"))
                throw new InvalidPostcode();
        }

        public static void ValidHomeNumber(int homeNumber)
        {
            if (homeNumber <= 0)
                throw new NotPositiveHomeNumber();
        }

        public static void ValidFlatNumber(int? flatNumber)
        {
            if (flatNumber != null && flatNumber <= 0)           
                throw new NotPositiveFlatNumber();         
        }
    }
}
