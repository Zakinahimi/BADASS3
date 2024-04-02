namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class DispatchSheet
{
    [Required]
    public int DispatchSheetID { get; set; }
    [Required]
    public int TrackID { get; set; }
    [Required]
    public int CompanyOrderID { get; set; }
    [Required]
    public string DeliveryPlace { get; set; }
    [Required]
    public string Signature { get; set; }
}
