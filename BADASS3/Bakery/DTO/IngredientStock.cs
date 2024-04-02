namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class IngredientStock
{
    [Required]
    public int Quantity { get; set; }
    [Required]
    public int IngredientStockID{ get; set; }
    [Required]
    public string Ingredient{ get; set; }
    [Required]
    public string Allergens { get; set; }
}
