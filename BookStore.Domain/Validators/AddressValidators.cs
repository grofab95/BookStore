using BookStore.Common.Exceptions;
using System.Text.RegularExpressions;

namespace BookStore.Domain.Validators
{
    public class AddressValidators
    {
        public static void ValidCity(string city)
        {
            if (string.IsNullOrEmpty(city))
                throw new MissingCity();
        }

        public static void ValidStreet(string street)
        {
            if (string.IsNullOrEmpty(street))
                throw new MissingStreet();
        }

        public static void ValidPostcode(string postCode)
        {
            if (string.IsNullOrEmpty(postCode))
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
