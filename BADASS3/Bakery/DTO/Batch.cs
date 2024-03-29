namespace Bakery.DTO;

public class Batch
{
    public int BatchID { get; set; }
    public DateTime TargetFinishTime { get; set; }
    public DateTime StartTime { get; set; }
    public int BakingGoodsListID { get; set; }
    public DateTime ActualFinishtTime { get; set; }
    public int IngredientStockID { get; set; }
}
