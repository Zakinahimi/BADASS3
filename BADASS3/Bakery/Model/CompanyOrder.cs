using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Model
{
    public class CompanyOrder
    {
        [Key]
        public int CompanyOrderId { get; set; }
        [Required] 
        public int Quantity { get;}
        [Required]
        public string BakingGoods { get; set; }

        public ICollection<Supermarket> Supermarket { get; set; }

    }
}
