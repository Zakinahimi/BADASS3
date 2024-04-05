using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BakingGoodsList",
                columns: table => new
                {
                    BakingGoodsListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BakingGoods = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakingGoodsList", x => x.BakingGoodsListID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyOrder",
                columns: table => new
                {
                    CompanyOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BakingGoods = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyOrderID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyOrder", x => x.CompanyOrderID);
                    table.ForeignKey(
                        name: "FK_CompanyOrder_CompanyOrder_CompanyOrderID1",
                        column: x => x.CompanyOrderID1,
                        principalTable: "CompanyOrder",
                        principalColumn: "CompanyOrderID");
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allergens = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientsID);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientsID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockID);
                });

            migrationBuilder.CreateTable(
                name: "DispatchSheet",
                columns: table => new
                {
                    DispatchSheetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyOrderID = table.Column<int>(type: "int", nullable: false),
                    TrackID = table.Column<int>(type: "int", nullable: false),
                    Driver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchSheet", x => x.DispatchSheetID);
                    table.ForeignKey(
                        name: "FK_DispatchSheet_CompanyOrder_CompanyOrderID",
                        column: x => x.CompanyOrderID,
                        principalTable: "CompanyOrder",
                        principalColumn: "CompanyOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supermarket",
                columns: table => new
                {
                    SupermarketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyOrderID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supermarket", x => x.SupermarketID);
                    table.ForeignKey(
                        name: "FK_Supermarket_CompanyOrder_CompanyOrderID",
                        column: x => x.CompanyOrderID,
                        principalTable: "CompanyOrder",
                        principalColumn: "CompanyOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    BatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakingGoodsListID = table.Column<int>(type: "int", nullable: false),
                    IngredientsID = table.Column<int>(type: "int", nullable: false),
                    TargetFinishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualFinishTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.BatchID);
                    table.ForeignKey(
                        name: "FK_Batch_BakingGoodsList_BakingGoodsListID",
                        column: x => x.BakingGoodsListID,
                        principalTable: "BakingGoodsList",
                        principalColumn: "BakingGoodsListID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Batch_Ingredient_IngredientsID",
                        column: x => x.IngredientsID,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    RecipeID = table.Column<int>(type: "int", nullable: false),
                    BakingGoodsListID = table.Column<int>(type: "int", nullable: false),
                    IngredientsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => new { x.BakingGoodsListID, x.IngredientsID, x.RecipeID });
                    table.ForeignKey(
                        name: "FK_Recipe_BakingGoodsList_BakingGoodsListID",
                        column: x => x.BakingGoodsListID,
                        principalTable: "BakingGoodsList",
                        principalColumn: "BakingGoodsListID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipe_Ingredient_IngredientsID",
                        column: x => x.IngredientsID,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpreadSheet",
                columns: table => new
                {
                    SpreadSheetID = table.Column<int>(type: "int", nullable: false),
                    CompanyOrderID = table.Column<int>(type: "int", nullable: false),
                    IngredientsID = table.Column<int>(type: "int", nullable: false),
                    BakingGoodsListID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpreadSheet", x => new { x.SpreadSheetID, x.CompanyOrderID, x.IngredientsID, x.BakingGoodsListID });
                    table.ForeignKey(
                        name: "FK_SpreadSheet_BakingGoodsList_BakingGoodsListID",
                        column: x => x.BakingGoodsListID,
                        principalTable: "BakingGoodsList",
                        principalColumn: "BakingGoodsListID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpreadSheet_CompanyOrder_CompanyOrderID",
                        column: x => x.CompanyOrderID,
                        principalTable: "CompanyOrder",
                        principalColumn: "CompanyOrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpreadSheet_Ingredient_IngredientsID",
                        column: x => x.IngredientsID,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientStock",
                columns: table => new
                {
                    IngredientsID = table.Column<int>(type: "int", nullable: false),
                    StocksStockID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientStock", x => new { x.IngredientsID, x.StocksStockID });
                    table.ForeignKey(
                        name: "FK_IngredientStock_Ingredient_IngredientsID",
                        column: x => x.IngredientsID,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientStock_Stock_StocksStockID",
                        column: x => x.StocksStockID,
                        principalTable: "Stock",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false),
                    BakingGoodsListID = table.Column<int>(type: "int", nullable: false),
                    BatchID = table.Column<int>(type: "int", nullable: false),
                    IngredientsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => new { x.ScheduleID, x.BakingGoodsListID, x.IngredientsID, x.BatchID });
                    table.ForeignKey(
                        name: "FK_Schedule_BakingGoodsList_BakingGoodsListID",
                        column: x => x.BakingGoodsListID,
                        principalTable: "BakingGoodsList",
                        principalColumn: "BakingGoodsListID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedule_Batch_BatchID",
                        column: x => x.BatchID,
                        principalTable: "Batch",
                        principalColumn: "BatchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedule_Ingredient_IngredientsID",
                        column: x => x.IngredientsID,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batch_BakingGoodsListID",
                table: "Batch",
                column: "BakingGoodsListID");

            migrationBuilder.CreateIndex(
                name: "IX_Batch_IngredientsID",
                table: "Batch",
                column: "IngredientsID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyOrder_CompanyOrderID1",
                table: "CompanyOrder",
                column: "CompanyOrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_DispatchSheet_CompanyOrderID",
                table: "DispatchSheet",
                column: "CompanyOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientStock_StocksStockID",
                table: "IngredientStock",
                column: "StocksStockID");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_BakingGoodsListID",
                table: "Recipe",
                column: "BakingGoodsListID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_IngredientsID",
                table: "Recipe",
                column: "IngredientsID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_BakingGoodsListID",
                table: "Schedule",
                column: "BakingGoodsListID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_BatchID",
                table: "Schedule",
                column: "BatchID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_IngredientsID",
                table: "Schedule",
                column: "IngredientsID");

            migrationBuilder.CreateIndex(
                name: "IX_SpreadSheet_BakingGoodsListID",
                table: "SpreadSheet",
                column: "BakingGoodsListID");

            migrationBuilder.CreateIndex(
                name: "IX_SpreadSheet_CompanyOrderID",
                table: "SpreadSheet",
                column: "CompanyOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_SpreadSheet_IngredientsID",
                table: "SpreadSheet",
                column: "IngredientsID");

            migrationBuilder.CreateIndex(
                name: "IX_Supermarket_CompanyOrderID",
                table: "Supermarket",
                column: "CompanyOrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DispatchSheet");

            migrationBuilder.DropTable(
                name: "IngredientStock");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "SpreadSheet");

            migrationBuilder.DropTable(
                name: "Supermarket");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "CompanyOrder");

            migrationBuilder.DropTable(
                name: "BakingGoodsList");

            migrationBuilder.DropTable(
                name: "Ingredient");
        }
    }
}
