using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bakery.DTO
{
    public class BakingGoodsListDTO
    {
        [Required]
        public int BakingGoodsListID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string BakingGoods { get; set; }
        [Required]
        public int RecipeID { get; set; }
    }
}
