using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepairShopWebApplication.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        public DateTime BillDate { get; set; }

        [ForeignKey(nameof(Fault))]
        public int FaultId { get; set; }
        public Fault Fault { get; set; }
    }
}
