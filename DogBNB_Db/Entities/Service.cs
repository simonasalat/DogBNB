

namespace DogBNB_Db.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public string ServiceType { get; set; }
        public decimal Price { get; set; }

    }
}
