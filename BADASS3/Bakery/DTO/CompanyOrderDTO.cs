using System.ComponentModel.DataAnnotations;

namespace Bakery.DTO;

public class CompanyOrderDTO
{
    [Required]
    public int CompanyOrderID { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public int BakingGoods { get; set; }
}
