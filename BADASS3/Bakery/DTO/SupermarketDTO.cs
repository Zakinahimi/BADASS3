using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bakery.DTO
{
    public class SupermarketDTO
    {
        [Required]
        public int SupermarketID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CompanyOrderID { get; set; }
    }

}
