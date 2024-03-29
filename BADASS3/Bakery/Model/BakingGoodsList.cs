using Bakery.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Recipe")]
        public int RecipeID { get; set; }
        public virtual Recipe Recipe { get; set; }


        public ICollection<SpreadSheet> SpreadSheet { get; set; }
    }
}
