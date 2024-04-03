namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class SpreadSheetDTO
{
    [Required]
    public int SpreadSheetDTOID { get; set; }
    [Required]
    public int CompanyOrderID { get; set; }
    [Required]
    public int IngredientStockID { get; set; }
    [Required]
    public int BakingGoodsListID { get; set; }
}
