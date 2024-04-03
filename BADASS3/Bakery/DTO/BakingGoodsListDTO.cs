namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class BakingGoodsListDTO
{
    [Required]
    public int BakingGoodsListDTOID { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public string BakingGoods { get; set; }
    [Required]
    public int RecipeID { get; set; }
}
