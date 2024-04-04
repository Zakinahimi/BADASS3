using Bakery.Database;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks; // Added using directive for Task

namespace Bakery.Controllers
{
    public class SeedController : Controller
    {
        private BakeryDbContext _context;

        public SeedController(BakeryDbContext context)
        {
            _context = context;
        }

        [HttpPost] // Moved above the method declaration

        public async Task<IActionResult> SeedDb()
        {
            
            var CompanyOrder = new CompanyOrder
            {

            };

            var Supermarket = new Supermarket
            {

            };

            var DispatchSheet = new DispatchSheet
            {

            };

            var BakingGoodsList = new BakingGoodsList
            { 
            
            };

            var Batch = new Batch
            { 
            
            };

            var Ingredients = new Ingredient
            { 
            
            };

            var Stock = new Stock
            { 
            
            };


            return Ok(); // Placeholder return statement
        }
    }
}
