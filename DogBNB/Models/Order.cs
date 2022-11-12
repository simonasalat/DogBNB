

namespace DogBNB.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string DogId { get; set; }
        public string SitterId { get; set; }
        public decimal Price { get; set; }
        public Service Service { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
