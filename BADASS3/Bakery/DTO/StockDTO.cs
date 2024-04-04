using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bakery.DTO
{
    public class StockDTO
    {
        [Required]
        public int StockID { get; set; }
        [Required]
        public string Name { get; set; }
    }

}