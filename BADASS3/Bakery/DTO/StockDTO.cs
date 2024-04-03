using System.ComponentModel.DataAnnotations;

namespace Bakery.DTO;

public class StockDTO
{
    [Required]
    public string StockDTOId { get; set; }
    [Required]
    public int Name { get; set; }
}
