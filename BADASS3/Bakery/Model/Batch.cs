using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Model
{
    public class Batch
    {

        //PRIMARY KEY
        [Key]
        public int BatchID { get; set; }


        //FOREIGN KEYS

        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public virtual BakingGoodsList BakingGoodsLists { get; set; }

        [ForeignKey("Ingredients")]
        public int IngredientsID { get; set; }
        public virtual Ingredient Ingredients { get; set; }


        //REQURIED
        [Required]
        public DateTime TargetFinishTime { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime ActualFinishTime { get; set; }


        //ICollection
        public ICollection<Schedule> Schedules { get; set; }
    }
}