using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Model
{
    public class BakingGoodsList
    {
        [Key]
        public int BakingGoodsListID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int BakingGoods { get; set; }

        [Required]
    }
}
