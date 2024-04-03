using Bakery.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public virtual CompanyOrder CompanyOrder { get; set; }

        [ForeignKey("Ingredient")]
        public int IngredientsID { get; set; }
        public Ingredient Ingredient { get; set; }

        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public BakingGoodsList BakingGoodsList { get; set; }

    }
}
