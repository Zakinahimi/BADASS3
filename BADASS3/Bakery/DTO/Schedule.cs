namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class Schedule
{
    [Required]
    public int ScheduleID { get; set; }
    [Required]
    public int BakingGoodsListID { get; set; }
    [Required]
    public int BatchID { get; set; }
    [Required]
    public int IngredientStockID { get; set; }
}
