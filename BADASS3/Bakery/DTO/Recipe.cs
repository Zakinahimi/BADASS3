namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class Recipe
{
    [Required]
    public int BakingGoodsListID { get; set; }
    [Required]
    public int RecipeID { get; set; }
    [Required]
    public int IngredientID { get; set; }
}
