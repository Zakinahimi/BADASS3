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
        //PRIMARY
        [Key]
        public int DispatchSheetID { get; set; }


        //FOREIGN
        [ForeignKey("CompanyOrder")]
        public int CompanyOrderID { get; set; }
        public virtual CompanyOrder CompanyOrder { get; set; }


        //REQUIRED
        [Required]
        public int TrackID { get; set; }

        [Required]
        public string Driver { get; set; }

        [Required]
        public string DeliveryPlace { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}
