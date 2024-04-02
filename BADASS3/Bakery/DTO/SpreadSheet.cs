namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class SpreadSheet
{
    [Required]
    public int SpreadSheetID { get; set; }
    [Required]
    public int CompanyOrderID { get; set; }
    [Required]
    public int IngredientStockID { get; set; }
    [Required]
    public int BakingGoodsListID { get; set; }
}
