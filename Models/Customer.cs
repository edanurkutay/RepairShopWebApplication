using System.ComponentModel.DataAnnotations;

namespace RepairShopWebApplication.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSuname { get; set; }
        public string CustomerTC { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public ICollection<Fault> faults { get; set; }


    }
}
