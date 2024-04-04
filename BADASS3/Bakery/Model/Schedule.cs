using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Model
{
    public class Schedule
    {
        //PRIMARY
        [Key]
        public int ScheduleID { get; set; }

        //FOREIGN
        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public virtual BakingGoodsList BakingGoodsLists { get; set; }


        [ForeignKey("Batch")]
        public int BatchID { get; set; }
        public virtual Batch Batches { get; set; }


        [ForeignKey("Ingredient")]
        public int IngredientsID { get; set; }
        public virtual Ingredient Ingredients { get; set; }
    }
}
