using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Model
{
    public class Supermarket
    {
        [Key]
        public int SupermarketID { get; set; }

        [Required]
        public string Name { get; set;}

        [ForeignKey("CompanyOrder")]
        public int CompanyOrderID { get; set; }
    }
}