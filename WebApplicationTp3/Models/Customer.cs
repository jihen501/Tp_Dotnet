using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTp3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Membership Name ")]
        [ForeignKey("Membershiptype")]
        public int MembershiptypeId { get; set; }
        public Membershiptype? Membershiptype { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
