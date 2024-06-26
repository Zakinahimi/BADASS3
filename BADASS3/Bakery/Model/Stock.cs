﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Model
{
    public class Stock
    {
        //PRIMARY
        [Key]
        public int StockID { get; set; }


        //FOREIGN
        [ForeignKey("Ingredients")]
        public int IngredientsID { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }

        // public virtual Ingredient Ingredient { get; set; }

        //REQUIRED
        [Required]
        public string Name { get; set; }
    }
}
