using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bakery.DTO;

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
        
        [Required]
        public string Allergens { get; set; }

        public ICollection<SpreadSheet> SpreadSheet { get; set; }

        public ICollection<Batch> Batch { get; set; }

        public ICollection<Schedule> Schedule { get; set; }
    }
}
