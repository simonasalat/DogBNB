

namespace DogBNB_Db.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string HouseNumber { get; set; }

    }
}
