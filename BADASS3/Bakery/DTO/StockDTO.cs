using System.ComponentModel.DataAnnotations;

namespace Bakery.DTO;

public class StockDTO
{
    [Required]
    public string StockId { get; set; }
    [Required]
    public int Name { get; set; }
}
