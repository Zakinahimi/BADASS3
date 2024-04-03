namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class RecipeDTO
{
    [Required]
    public int BakingGoodsListID { get; set; }
    [Required]
    public int RecipeDTOID { get; set; }
    [Required]
    public int IngredientID { get; set; }
}
