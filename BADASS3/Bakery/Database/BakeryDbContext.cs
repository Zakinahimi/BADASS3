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
    public DbSet<Ingredient> Ingredient => Set<Ingredient>();
    public DbSet<Supermarket> Supermarket => Set<Supermarket>();
    public DbSet<Schedule> Schedule => Set<Schedule>();
    public DbSet<Recipe> Recipe => Set<Recipe>();
    public DbSet<Stock> Stock => Set<Stock>();



    // SHADOW PROPERTIES

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SpreadSheet>()
            .HasKey(ss => new { ss.SpreadSheetID, ss.CompanyOrderID, ss.IngredientsID, ss.StockID, ss.BakingGoodsListID });

        modelBuilder.Entity<Schedule>()
            .HasKey(s => new { s.ScheduleID, s.BakingGoodsListID, s.IngredientsID, s.StockID, s.BatchID });

        modelBuilder.Entity<Recipe>()
            .HasKey(r => new { r.BakingGoodsListID, r.IngredientsID, r.StockID, r.RecipeID });
    }

}