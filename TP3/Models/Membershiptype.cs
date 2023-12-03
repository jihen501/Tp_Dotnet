namespace TP3.Models
{
    public class Membershiptype
    {
        public int Id { get; set; }
        public string SignUpFee { get; set; }
        public int DurationInMonth { get; set; }
        public int DiscountRate {  get; set; }
        public ICollelction <Customers> Customers { get;set; }
    }
}

