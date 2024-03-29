using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Model
{
    public class IngredientsStock
    {
        [Key]
        public int IngredientsStockID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Ingredient { get; set; }

        public ICollection<SpreadSheet> SpreadSheet { get; set; }
    }
}
