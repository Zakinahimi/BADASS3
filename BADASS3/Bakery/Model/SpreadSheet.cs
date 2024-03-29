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
        [Key]
        public int SpreadSheetID { get; set; }

        [ForeignKey("CompanyOrder")]
        public int CompanyOrderId { get; set; }
        public virtual CompanyOrder CompanyOrder { get; set; }

        [ForeignKey("IngredientsStock")]
        public int IngredientsStockID { get; set; }
        public virtual IngredientsStock IngredientsStock { get; set; }

        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public virtual BakingGoodsList BakingGoodsList { get; set; }


    }
}
