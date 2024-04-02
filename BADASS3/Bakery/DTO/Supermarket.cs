namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class Supermarket
{
    [Required]
    public int SupermarketID { get; set; }
    [Required]
    public string Name  { get; set; }
    [Required]
    public int CompanyOrderID { get; set; }
}
