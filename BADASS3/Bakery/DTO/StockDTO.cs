using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bakery.DTO
{
    public class StockDTO
    {
        [Required]
        public string StockID { get; set; }
        [Required]
        public int Name { get; set; }
    }

}