using System.ComponentModel.DataAnnotations;

namespace WebApplicationTp3.Models
{
    public class Membershiptype
    {
        [Key]
        public int Id { get; set; }
        public Double SignUpFee { get; set; }
        public int DurationMonth { get; set; }
        public int DiscountRate { get; set; }   
        public List<Customer> Customers { get; set; }
    }
}
