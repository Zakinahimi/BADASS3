using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Model
{
    public class DispatchSheet
    {
        [Key]
        public int DispatchSheetID { get; set; }

        [ForeignKey("CompanyOrder")]
        public int CompanyOrderID { get; set; }

        [Required]
        public string TrackID { get; set; }

        [Required]
        public string DeliveryPlace { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}
