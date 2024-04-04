using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bakery.DTO
{
    public class DispatchSheetDTO
    {
        [Required]
        public int DispatchSheetID { get; set; }
        [Required]
        public int TrackID { get; set; }
        [Required]
        public int CompanyOrderID { get; set; }
        [Required]
        public string DeliveryPlace { get; set; }
        [Required]
        public string Signature { get; set; }
    }
}
