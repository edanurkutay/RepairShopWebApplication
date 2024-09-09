using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RepairShopWebApplication.Models
{
    public class Fault
    {
        [Key]
        public int FaultId { get; set; }
        public string FaultMessage { get; set; }
        public string FaultyDevice { get; set; }

        [DefaultValue("Kayıt Oluşturuldu")]
        public string FaultState { get; set; } 
        public int Price { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Bill Bill { get; set; }

    }
}
