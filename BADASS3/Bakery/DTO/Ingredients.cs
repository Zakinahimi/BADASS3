namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class Ingredients
{
    [Required]
    public int Quantity { get; set; }
    [Required]
    public int IngredientsID{ get; set; }
    [Required]
    public string Ingredient{ get; set; }
    [Required]
    public string Allergens { get; set; }
}
