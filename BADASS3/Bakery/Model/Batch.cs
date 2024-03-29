using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bakery.DTO;

namespace Bakery.Model
{
    public class Batch
    {
        [Key]
        public int BatchID { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime TargetFinishTime { get; set; }

        [Required]
        public DateTime ActualFinishTime { get; set; }


        [ForeignKey("BakingGoodsList")]
        public int BakingGoodsListID { get; set; }
        public virtual BakingGoodsList BakingGoodsList { get; set; }

        [ForeignKey("IngredientsStock")]
        public int IngredientsStockID { get; set; }
        public virtual IngredientsStock IngredientsStock { get; set; }


        public ICollection<Schedule> Schedules { get; set; }
    }
}