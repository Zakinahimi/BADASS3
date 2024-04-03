using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bakery.DTO;

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
        public virtual BakingGoodsList BakingGoodsList { get; set; }

        [ForeignKey("Ingredients")]
        public int IngredientsID { get; set; }
        public virtual Ingredients Ingredients { get; set; }


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