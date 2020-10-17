using BookStore.Common.Validators;

namespace BookStore.Domain.Entities
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public int? FlatNumber { get; set; }
        public string PostCode { get; set; }

        public Address(string city, string street, string postcode, int homeNumber, int? flatNumber = null)
        {
            AddressValidators.ValidCity(city);
            AddressValidators.ValidStreet(street);
            AddressValidators.ValidPostcode(postcode);
            AddressValidators.ValidHomeNumber(homeNumber);
            AddressValidators.ValidFlatNumber(flatNumber);

            City = city;
            Street = street;
            PostCode = postcode;
            HomeNumber = homeNumber;
            FlatNumber = flatNumber;
        }
    }
}
