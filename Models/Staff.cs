using System.ComponentModel.DataAnnotations;

namespace RepairShopWebApplication.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffSurname { get;set; }
        public string username { get; set; }    
        public string password { get; set; }
    }
}
