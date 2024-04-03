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
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        
        [ForeignKey("Ingredients")]
        public int IngredientsID { get; set; }
        public virtual Ingredient Ingredients { get; set; }

        [Required]
        public string Name { get; set;}
    }
}
