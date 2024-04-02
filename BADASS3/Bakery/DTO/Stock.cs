using System.ComponentModel.DataAnnotations;

namespace Bakery.DTO;

public class Stock
{
    [Required]
    public string StockId { get; set; }
    [Required]
    public int Quantity { get; set; }
}
