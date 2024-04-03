using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Model
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public virtual BakingGoodsList BakingGoodsList { get; set; }

        [ForeignKey("Ingredients")]
        public int IngredientsID { get; set; }
        public virtual Ingredients Ingredients { get; set; }

    }
}
