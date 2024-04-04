using Bakery.Database;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class SeedController : Controller
    {
        private BakeryDbContext _context;

        public SeedController(BakeryDbContext context)
        {
            _context = context;
        }

        [HttpPost] 

        public async Task<IActionResult> SeedDb()
        {
            
            var CompanyOrder = new CompanyOrder
            {
                BakingGoods = "cake 1, cake 2",
                Quantity = 1 
            };

            var Supermarket = new Supermarket
            {
                Name = "Netto"
            };
            if (!_context.Supermarket.Any(c => c.SupermarketID == Supermarket.SupermarketID))
            {
                await _context.Supermarket.AddAsync(Supermarket);
                await _context.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine("Supermarket already exists.");
            }

            var DispatchSheet = new DispatchSheet
            {
                 Driver = "ZAKIII",
                 TrackID = 1,   
                 DeliveryPlace = "yep",
                 DeliveryDate = new DateTime(2024, 4, 5),
                 Signature = "yes"
            };

            var BakingGoodsList = new BakingGoodsList
            { 
                Quantity = 1,   
                BakingGoods = "mad"
            };
            if (!_context.BakingGoodsList.Any(e => e.BakingGoodsListID == BakingGoodsList.BakingGoodsListID))
            {
                await _context.BakingGoodsList.AddAsync(BakingGoodsList);
                await _context.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine("BakingGoodsList already exists.");
            }

            var Batch = new Batch
            { 
                TargetFinishTime = new DateTime(2024, 4, 3, 11, 30, 00),
                StartTime = DateTime.Now,
                ActualFinishTime = new DateTime(2024, 4, 3, 12, 17, 11),
            };
            if (!_context.Batch.Any(e => e.BatchID == Batch.BatchID))
            {
                await _context.Batch.AddAsync(Batch);
                await _context.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine("batch already exists.");
            }

            var Ingredients = new Ingredient
            { 
                Quantity = 1,
                Name = "Sugar",
                Allergens = "die"
            };


            var Stock = new Stock
            { 
                Name = "IDK"
            };
            if (!_context.Stock.Any(e => e.StockID == Stock.StockID))
            {
                await _context.Stock.AddAsync(Stock);
                await _context.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine("stock already exists.");
            }

            return CreatedAtAction(nameof(SeedDb), new { id = Supermarket.SupermarketID }, Supermarket);
        }
    }
}
