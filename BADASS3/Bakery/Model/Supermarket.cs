using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Model
{
    public class Supermarket
    {
        //PRIMARY
        [Key]
        public int SupermarketID { get; set; }


        //FOREIGN
        [ForeignKey("CompanyOrder")]
        public int CompanyOrderID { get; set; }


        //REQUIRED
        [Required]
        public string Name { get; set; }
    }
}