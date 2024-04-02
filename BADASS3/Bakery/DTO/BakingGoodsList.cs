namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class BakingGoodsList
{
    [Required]
    public int BakingGoodsListID { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public string BakingGoods { get; set; }
    [Required]
    public int RecipeID { get; set; }
}
