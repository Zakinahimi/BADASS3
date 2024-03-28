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
        public virtual CompanyOrder CompanyOrder { get; set; }

        public string TrackID { get; set; }
        public string Route { get; set; }
        public string DeliveryPlace { get; set; }
        public string Signature { get; set; }
    }
}
