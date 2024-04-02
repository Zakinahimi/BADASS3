using Bakery.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Bakery.Database;

public class BakeryDbContext : DbContext
{
    public BakeryDbContext(DbContextOptions<BakeryDbContext> options)
        : base(options)
    {
    }

    public DbSet<DispatchSheet> DispatchSheet => Set<DispatchSheet>();
    public DbSet<SpreadSheet> SpreadSheet => Set<SpreadSheet>();
    public DbSet<Batch> Batch => Set<Batch>();
    public DbSet<BakingGoodsList> BakingGoodsList => Set<BakingGoodsList>();
    public DbSet<CompanyOrder> CompanyOrder => Set<CompanyOrder>();
    public DbSet<IngredientsStock> IngredientsStock => Set<IngredientsStock>();
    public DbSet<Supermarket> Supermarket => Set<Supermarket>();
    public DbSet<Schedule> Schedule => Set<Schedule>();
    public DbSet<Recipe> Recipe => Set<Recipe>();



    // SHADOW PROPERTIES
    // KENDER IKKE FORSKELLEN PÅ go og ib og hvad de gør


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SpreadSheet>()
            .HasKey(go => new { go.SpreadSheetID, go.CompanyOrderId, go.IngredientsStockID, go.BakingGoodsListID });

        modelBuilder.Entity<Schedule>()
            .HasKey(go => new { go.ScheduleID, go.BakingGoodsListID, go.IngredientsStockID, go.BatchID });

        modelBuilder.Entity<Recipe>()
            .HasKey(go => new { go.BakingGoodsListID, go.IngredientsStockID, go.RecipeID });
    }


    // det her er gregs:
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    // Goods + Order
    //    modelBuilder.Entity<GoodsOrder>()
    //        .HasKey(go => new { go.GoodsId, go.OrderId });

    //    // Ingredient + Batch
    //    modelBuilder.Entity<IngredientBatch>()
    //        .HasKey(ib => new { ib.IngredientId, ib.BatchId });
    //}
}