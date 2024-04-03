namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class BatchDTO
{
    [Required]
    public int BatchDTOID { get; set; }
    [Required]
    public DateTime TargetFinishTime { get; set; }
    [Required]
    public DateTime StartTime { get; set; }
    public int BakingGoodsListID { get; set; }
    [Required]
    public DateTime ActualFinishtTime { get; set; }
    public int IngredientStockID { get; set; }
}
