using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Model
{
    public class CompanyOrder
    {
        //PRIMARY
        [Key]
        public int CompanyOrderID { get; set; }

        //REQUIRED
        [Required]
        public int Quantity { get; set; }

        [Required]
        public string BakingGoods { get; set; }


        //ICollection
        public ICollection<Supermarket> Supermarkets { get; set; }
        public ICollection<CompanyOrder> CompanyOrders { get; set; }
        public ICollection<SpreadSheet> SpreadSheets { get; set; }
    }
}
