using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public virtual Recipe Recipes { get; set; }

        //REQUIRED
        [Required]
        public int Quantity { get; set; }

        [Required]
        public string BakingGoods { get; set; }


        //ICollection
        public ICollection<SpreadSheet> SpreadSheets { get; set; }

        public ICollection<Batch> Batches { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
