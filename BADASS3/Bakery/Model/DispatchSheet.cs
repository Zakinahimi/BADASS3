using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Model
{
    public class DispatchSheet
    {
        //PRIMARY
        [Key]
        public int DispatchSheetID { get; set; }


        //FOREIGN
        [ForeignKey("CompanyOrder")]
        public int CompanyOrderID { get; set; }
        public virtual CompanyOrder CompanyOrders { get; set; }


        //REQUIRED
        [Required]
        public int TrackID { get; set; }

        [Required]
        public string Driver { get; set; }

        [Required]
        public string DeliveryPlace { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}
