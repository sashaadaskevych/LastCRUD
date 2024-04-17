using System.ComponentModel.DataAnnotations;

namespace sasha.addclasses
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerRegion { get; set; }
    }
}
