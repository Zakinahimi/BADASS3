namespace Bakery.DTO;
using System.ComponentModel.DataAnnotations;

public class DispatchSheetDTO
{
    [Required]
    public int DispatchSheetDTOID { get; set; }
    [Required]
    public int TrackID { get; set; }
    [Required]
    public int CompanyOrderID { get; set; }
    [Required]
    public string DeliveryPlace { get; set; }
    [Required]
    public string Signature { get; set; }
}
