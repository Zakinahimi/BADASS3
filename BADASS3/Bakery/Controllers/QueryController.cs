using Bakery.Database;
using Bakery.DTO;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public QueryController(BakeryDbContext context)
        {
            _context = context;
        }

        // Query 1: Get the current stock
        [HttpGet("GetCurrentStock")]
        public async Task<ActionResult<IEnumerable<StockDTO>>> GetCurrentStock()
        {
            var stocks = await _context.Stock
                .Select(s => new StockDTO
                {
                    StockID = s.StockID,
                    Name = s.Name,
                }).ToListAsync();

            return Ok(stocks);
        }

        // Query 2: Get the address and date for an order
        [HttpGet("GetOrderDetails/{CompanyOrderId}")]
        public async Task<ActionResult> GetOrderDetails(int CompanyOrderId)
        {
            var orderDetails = await _context.DispatchSheet
                .Where(o => o.CompanyOrderID == CompanyOrderId)
                .Include(o => o.DeliveryPlace)
                .Select(o => new { Address = o.DeliveryPlace, o.DeliveryDate})
                .FirstOrDefaultAsync();

            if (orderDetails == null)
                return NotFound($"Details not found for order ID: {CompanyOrderId}");

            return Ok(orderDetails);
        }

        // Query 3: Get the list of baked goods in an order
        [HttpGet("GetGoodsInOrder/{orderId}")]
        public async Task<ActionResult> GetGoodsInOrder(int orderId)
        {
            var goodsList = await _context.CompanyOrder
                .Where(go => go.CompanyOrderID == orderId)
                .Include(go => go.BakingGoods)
                .Select(go => new { Goods = go.BakingGoods, Quantity = go.Quantity })
                .ToListAsync();

            if (goodsList == null || !goodsList.Any())
                return NotFound($"No goods found for order ID: {orderId}");

            return Ok(goodsList);
        }

        // Query 4: Get the ingredients for a batch
        [HttpGet("GetIngredientsForBatch/{batchId}")]
        public async Task<ActionResult> GetIngredientsForBatch(int batchId)
        {
            var ingredients = await _context.Batch
                .Where(ib => ib.BatchID == batchId)
                .Include(ib => ib.Ingredients)
                .Select(ib => new { IngredientName = ib.Ingredients.Name, Allergens = ib.Ingredients.Allergens, Quantity = ib.Ingredients.Quantity })
                .ToListAsync();

            if (ingredients == null || !ingredients.Any())
                return NotFound($"No ingredients found for batch ID: {batchId}");

            return Ok(ingredients);
        }

        // Query 5: Get the track ids for order
        [HttpGet("GetTrackIdsForOrder/{orderId}")]
        public async Task<ActionResult> GetTrackIdsForOrder(int orderId)
        {
            var trackIds = await _context.DispatchSheet
                .Where(d => d.CompanyOrderID == orderId)
                .Select(d => new { d.TrackID, d.DeliveryPlace })
                .ToListAsync();

            if (trackIds == null || !trackIds.Any())
                return NotFound($"No track IDs found for order ID: {orderId}");

            return Ok(trackIds);
        }

        // Query 6: Get all quantities for goods
        [HttpGet("GetAllGoodsQuantities")]
        public async Task<ActionResult> GetAllGoodsQuantities()
        {
            var goodsQuantities = await _context.SpreadSheet
                .Include(go => go.BakingGoodsLists)  
                .GroupBy(go => go.BakingGoodsLists.BakingGoods)
                .Select(g => new { BakingGoods = g.Key, TotalQuantity = g.Sum(go => go.Quantity) })
                .OrderBy(g => g.BakingGoods)
                .ToListAsync();

            return Ok(goodsQuantities);
        }
        // Query 7: Get the average delay 
        [HttpGet("GetAverageBatchDelay")]
        public async Task<ActionResult> GetAverageBatchDelay()
        {
            var averageDelay = await _context.Batch
                .Where(b => b.TargetFinishTime != null && b.ActualFinishTime != null)
                .Select(b => (int?)((b.ActualFinishTime - b.TargetFinishTime).TotalMinutes))
                .AverageAsync();

            if (averageDelay == null)
                return NotFound("No data found");

            return Ok(new { AverageDelay = averageDelay });
        }
    }
}
