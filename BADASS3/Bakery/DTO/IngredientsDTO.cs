using System.ComponentModel.DataAnnotations;

namespace Bakery.DTO;

public class IngredientsDTO
{
    [Required]
    public int Quantity { get; set; }
    [Required]
    public int IngredientsID{ get; set; }
    [Required]
    public string Name{ get; set; }
    [Required]
    public string Allergens { get; set; }
}
