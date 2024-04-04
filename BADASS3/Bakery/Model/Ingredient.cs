using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bakery.Model
{
    public class Ingredient
    {
        [Key]
        public int IngredientsID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Allergens { get; set; }


        public ICollection<Stock> Stocks { get; set; }

        public ICollection<SpreadSheet> SpreadSheets { get; set; }

        public ICollection<Recipe> Recipes { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
