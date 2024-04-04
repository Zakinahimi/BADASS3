using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bakery.Model
{
    public class SpreadSheet
    {
        //PRIMARY
        [Key]
        public int SpreadSheetID { get; set; }


        //FOREIGN
        [ForeignKey("CompanyOrder")]
        public int CompanyOrderID { get; set; }
        public virtual CompanyOrder CompanyOrders { get; set; }

        [ForeignKey("Ingredient")]
        public int IngredientsID { get; set; }
        public Ingredient Ingredients { get; set; }

        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public BakingGoodsList BakingGoodsLists { get; set; }

    }
}
