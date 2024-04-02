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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SpreadSheet>()
            .HasKey(ss => new { ss.SpreadSheetID, ss.CompanyOrderId, ss.IngredientsStockID, ss.BakingGoodsListID });

        modelBuilder.Entity<Schedule>()
            .HasKey(s => new { s.ScheduleID, s.BakingGoodsListID, s.IngredientsStockID, s.BatchID });

        modelBuilder.Entity<Recipe>()
            .HasKey(r => new { r.BakingGoodsListID, r.IngredientsStockID, r.RecipeID });
    }

}
