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
        //PRIMARY
        [Key]
        public int StockId { get; set; }


        //FOREIGN
        [ForeignKey("Ingredients")]
        public int IngredientsID { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }

        // public virtual Ingredient Ingredient { get; set; }


        //REQUIRED
        [Required]
        public string Name { get; set;}
    }
}
