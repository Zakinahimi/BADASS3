using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Model
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public virtual BakingGoodsList BakingGoodsLists { get; set; }

        [ForeignKey("Ingredients")]
        public int IngredientsID { get; set; }
        public virtual Ingredient Ingredients { get; set; }

    }
}
