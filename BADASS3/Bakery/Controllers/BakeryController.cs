using Bakery.Database;
using Bakery.DTO;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bad3.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HomeController : ControllerBase
	{
		private readonly BakeryDbContext _context;

		public HomeController(BakeryDbContext context)
		{
			_context = context;
		}

		// GET: ALL
		[HttpGet("GetAllIngredients")]
		public async Task<ActionResult<IEnumerable<IngredientStock>>> GetAllIngredients()
		{
			var ingredients = await _context.IngredientsStock.Include(i => i.Ingredient).Select(i => new IngredientStock
			{
                IngredientStockID = i.IngredientsStockID,
				Ingredient = i.Ingredient,
				Quantity = i.Quantity,
                Allergens = i.Allergens
				
			}).ToListAsync();

			return Ok(ingredients);
		}

		// POST
		[HttpPost("AddIngredient")]
		public async Task<ActionResult> AddIngredient([FromBody] IngredientsStock ingredientStock)
		{
			if (ingredientStock.Quantity < 0)
				return BadRequest("negativ number");

			var ingredient = new IngredientsStock
			{
				IngredientsStockID = ingredientStock.IngredientsStockID,
				Quantity = ingredientStock.Quantity,
				Ingredient = new List<IngredientsStock>() // collection of ingredients
			};

			ingredient.Ingredient.Add(ingredient)

			_context.IngredientsStock.Add(ingredient); // add to database
			await _context.SaveChangesAsync();

			return Ok($"{ingredientStock.IngredientsStockID} added with quantity {ingredientStock.Quantity} and allergens {ingredientStock.Allergens}");
		}


		// PUT
		[HttpPut("UpdateIngredient")]
		public async Task<IActionResult> UpdateIngredient([FromBody] IngredientStock ingredientDto)
		{
			if (ingredientDto.Quantity < 0)
				return BadRequest("negativ number");

			var stock = await _context.IngredientsStock
				.Include(s => s.Ingredient)
				.FirstOrDefaultAsync(s => s.Ingredient.Any(i => i.Ingredient == ingredientDto.Ingredient));

			if (stock == null)
				return NotFound($"{ingredientDto.IngredientStockID} not found");

			var ingredient = stock.Ingredients.FirstOrDefault(i => i.Name == ingredientDto.Ingredient);
			if (ingredient != null)
			{
				stock.Quantity = ingredientDto.Quantity; // update quant
				ingredient.Allergens = ingredientDto.Allergens; // update allergens
				await _context.SaveChangesAsync(); // save
				return Ok($"{ingredient.Name} quantity updated to {ingredientDto.Quantity} and allergens to {ingredientDto.Allergens}");
			}

			return NotFound($"{ingredientDto.Ingredient} not found");
		}

		// DELETE
		[HttpDelete("DeleteIngredient")]
		public async Task<IActionResult> DeleteIngredient([FromQuery] string name)
		{
			var ingredient = await _context.IngredientsStock
										  .Include(i => i.Ingredient)
										  .SingleOrDefaultAsync(i => i.Ingredient == name);

			if (ingredient == null)
			{
				return NotFound($"{name} not found");
			}

			_context.IngredientsStock.Remove(ingredient);

			// see if others are linked to same stock
			bool hasOtherIngredients = await _context.IngredientsStock.AnyAsync(i => i.StockId == ingredient.StockId && i.IngredientsStockID != ingredient.IngredientsStockID);
			if (!hasOtherIngredients)
			{
				var stock = await _context.Stock.FindAsync(ingredient.StockId);
				if (stock != null)
				{
					// delete stock associated with ingredient
					_context.Stock.Remove(stock);
				}
			}

			await _context.SaveChangesAsync(); // commit delete

			return Ok($"{name} deleted");
		}
	}
}
