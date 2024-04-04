using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Bakery.DTO
{
    public class CompanyOrderDTO
    {
        [Required]
        public int CompanyOrderID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string BakingGoods { get; set; }
    }

}