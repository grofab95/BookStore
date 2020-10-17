using BookStore.Domain.Validators;

namespace BookStore.Domain.Entities
{
    public class Address
    {
        public string City { get; }
        public string Street { get; }
        public string PostCode { get; }
        public int HomeNumber { get; }
        public int? FlatNumber { get; }        

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

        public string GetAddress() => FlatNumber == null
            ? $"{PostCode} {City}, ul. {Street} {HomeNumber}"
            : $"{PostCode} {City}, ul. {Street} {HomeNumber}/{FlatNumber}";        
    }
}
