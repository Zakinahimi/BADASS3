namespace Bakery.DTO;

public class DispatchSheet
{
    public int DispatchSheetID { get; set; }
    public int TrackID { get; set; }
    public int CompanyOrderID { get; set; }
    public string DeliveryPlace { get; set; }
    public string Signature { get; set; }
}
