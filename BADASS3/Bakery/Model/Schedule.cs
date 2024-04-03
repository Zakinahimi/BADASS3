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
    public class Schedule
    {
        //PRIMARY
        [Key]
        public int ScheduleID { get; set; }

        //FOREIGN
        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public virtual BakingGoodsList BakingGoodsList { get; set; }


        [ForeignKey("Batch")]
        public int BatchID { get; set; }
        public virtual Batch Batch { get; set; }


        [ForeignKey("Ingredient")]
        public int IngredientsID { get; set; }
        public virtual Ingredient Ingredients { get; set; }
    }
}
