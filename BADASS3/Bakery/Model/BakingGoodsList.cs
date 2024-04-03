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
        //PRIMARY
        [Key]
        public int BakingGoodsListID { get; set; }

        //FOREIGN
        [ForeignKey("Recipe")]
        public int RecipeID { get; set; }
        public virtual Recipe Recipe { get; set; }


        //REQUIRED
        [Required]
        public int Quantity { get; set; }

        [Required]
        public string BakingGoods { get; set; }


        //ICollection
        public ICollection<SpreadSheet> SpreadSheet { get; set; }
        
        public ICollection<Batch> Batch { get; set; }

        public ICollection<Schedule> Schedule { get; set; }
    }
}
