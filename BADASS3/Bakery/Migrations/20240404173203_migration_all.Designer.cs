﻿// <auto-generated />
using System;
using Bakery.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bakery.Migrations
{
    [DbContext(typeof(BakeryDbContext))]
    [Migration("20240404173203_migration_all")]
    partial class migration_all
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bakery.Model.BakingGoodsList", b =>
                {
                    b.Property<int>("BakingGoodsListID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BakingGoodsListID"));

                    b.Property<string>("BakingGoods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.HasKey("BakingGoodsListID");

                    b.ToTable("BakingGoodsList");
                });

            modelBuilder.Entity("Bakery.Model.Batch", b =>
                {
                    b.Property<int>("BatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchID"));

                    b.Property<DateTime>("ActualFinishTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("BakingGoodsListID")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TargetFinishTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BatchID");

                    b.HasIndex("BakingGoodsListID");

                    b.HasIndex("IngredientsID");

                    b.ToTable("Batch");
                });

            modelBuilder.Entity("Bakery.Model.CompanyOrder", b =>
                {
                    b.Property<int>("CompanyOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyOrderID"));

                    b.Property<string>("BakingGoods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyOrderID1")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CompanyOrderID");

                    b.HasIndex("CompanyOrderID1");

                    b.ToTable("CompanyOrder");
                });

            modelBuilder.Entity("Bakery.Model.DispatchSheet", b =>
                {
                    b.Property<int>("DispatchSheetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DispatchSheetID"));

                    b.Property<int>("CompanyOrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Driver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackID")
                        .HasColumnType("int");

                    b.HasKey("DispatchSheetID");

                    b.HasIndex("CompanyOrderID");

                    b.ToTable("DispatchSheet");
                });

            modelBuilder.Entity("Bakery.Model.Ingredient", b =>
                {
                    b.Property<int>("IngredientsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientsID"));

                    b.Property<string>("Allergens")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IngredientsID");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("Bakery.Model.Recipe", b =>
                {
                    b.Property<int>("BakingGoodsListID")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsID")
                        .HasColumnType("int");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.HasKey("BakingGoodsListID", "IngredientsID", "RecipeID");

                    b.HasIndex("BakingGoodsListID")
                        .IsUnique();

                    b.HasIndex("IngredientsID");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("Bakery.Model.Schedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.Property<int>("BakingGoodsListID")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsID")
                        .HasColumnType("int");

                    b.Property<int>("BatchID")
                        .HasColumnType("int");

                    b.HasKey("ScheduleID", "BakingGoodsListID", "IngredientsID", "BatchID");

                    b.HasIndex("BakingGoodsListID");

                    b.HasIndex("BatchID");

                    b.HasIndex("IngredientsID");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("Bakery.Model.SpreadSheet", b =>
                {
                    b.Property<int>("SpreadSheetID")
                        .HasColumnType("int");

                    b.Property<int>("CompanyOrderID")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsID")
                        .HasColumnType("int");

                    b.Property<int>("BakingGoodsListID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("SpreadSheetID", "CompanyOrderID", "IngredientsID", "BakingGoodsListID");

                    b.HasIndex("BakingGoodsListID");

                    b.HasIndex("CompanyOrderID");

                    b.HasIndex("IngredientsID");

                    b.ToTable("SpreadSheet");
                });

            modelBuilder.Entity("Bakery.Model.Stock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"));

                    b.Property<int>("IngredientsID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StockID");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Bakery.Model.Supermarket", b =>
                {
                    b.Property<int>("SupermarketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupermarketID"));

                    b.Property<int>("CompanyOrderID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupermarketID");

                    b.HasIndex("CompanyOrderID");

                    b.ToTable("Supermarket");
                });

            modelBuilder.Entity("IngredientStock", b =>
                {
                    b.Property<int>("IngredientsID")
                        .HasColumnType("int");

                    b.Property<int>("StocksStockID")
                        .HasColumnType("int");

                    b.HasKey("IngredientsID", "StocksStockID");

                    b.HasIndex("StocksStockID");

                    b.ToTable("IngredientStock");
                });

            modelBuilder.Entity("Bakery.Model.Batch", b =>
                {
                    b.HasOne("Bakery.Model.BakingGoodsList", "BakingGoodsLists")
                        .WithMany("Batches")
                        .HasForeignKey("BakingGoodsListID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Model.Ingredient", "Ingredients")
                        .WithMany()
                        .HasForeignKey("IngredientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGoodsLists");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Bakery.Model.CompanyOrder", b =>
                {
                    b.HasOne("Bakery.Model.CompanyOrder", null)
                        .WithMany("CompanyOrders")
                        .HasForeignKey("CompanyOrderID1");
                });

            modelBuilder.Entity("Bakery.Model.DispatchSheet", b =>
                {
                    b.HasOne("Bakery.Model.CompanyOrder", "CompanyOrders")
                        .WithMany()
                        .HasForeignKey("CompanyOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyOrders");
                });

            modelBuilder.Entity("Bakery.Model.Recipe", b =>
                {
                    b.HasOne("Bakery.Model.BakingGoodsList", "BakingGoodsLists")
                        .WithOne("Recipes")
                        .HasForeignKey("Bakery.Model.Recipe", "BakingGoodsListID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Model.Ingredient", "Ingredients")
                        .WithMany("Recipes")
                        .HasForeignKey("IngredientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGoodsLists");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Bakery.Model.Schedule", b =>
                {
                    b.HasOne("Bakery.Model.BakingGoodsList", "BakingGoodsLists")
                        .WithMany("Schedules")
                        .HasForeignKey("BakingGoodsListID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Model.Batch", "Batches")
                        .WithMany("Schedules")
                        .HasForeignKey("BatchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Model.Ingredient", "Ingredients")
                        .WithMany("Schedules")
                        .HasForeignKey("IngredientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGoodsLists");

                    b.Navigation("Batches");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Bakery.Model.SpreadSheet", b =>
                {
                    b.HasOne("Bakery.Model.BakingGoodsList", "BakingGoodsLists")
                        .WithMany("SpreadSheets")
                        .HasForeignKey("BakingGoodsListID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Model.CompanyOrder", "CompanyOrders")
                        .WithMany("SpreadSheets")
                        .HasForeignKey("CompanyOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Model.Ingredient", "Ingredients")
                        .WithMany("SpreadSheets")
                        .HasForeignKey("IngredientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGoodsLists");

                    b.Navigation("CompanyOrders");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Bakery.Model.Supermarket", b =>
                {
                    b.HasOne("Bakery.Model.CompanyOrder", null)
                        .WithMany("Supermarkets")
                        .HasForeignKey("CompanyOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IngredientStock", b =>
                {
                    b.HasOne("Bakery.Model.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Model.Stock", null)
                        .WithMany()
                        .HasForeignKey("StocksStockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bakery.Model.BakingGoodsList", b =>
                {
                    b.Navigation("Batches");

                    b.Navigation("Recipes")
                        .IsRequired();

                    b.Navigation("Schedules");

                    b.Navigation("SpreadSheets");
                });

            modelBuilder.Entity("Bakery.Model.Batch", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Bakery.Model.CompanyOrder", b =>
                {
                    b.Navigation("CompanyOrders");

                    b.Navigation("SpreadSheets");

                    b.Navigation("Supermarkets");
                });

            modelBuilder.Entity("Bakery.Model.Ingredient", b =>
                {
                    b.Navigation("Recipes");

                    b.Navigation("Schedules");

                    b.Navigation("SpreadSheets");
                });
#pragma warning restore 612, 618
        }
    }
}
