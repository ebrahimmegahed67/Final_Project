﻿// <auto-generated />
using System;
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_Project.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20240930153331_v3")]
    partial class v3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final_Project.Models.categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Final_Project.Models.customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("billing_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("default_shipping_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Final_Project.Models.order_details", b =>
                {
                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("product_id", "order_id");

                    b.HasIndex("order_id");

                    b.ToTable("order_details");
                });

            modelBuilder.Entity("Final_Project.Models.orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<string>("orders_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("orders_date")
                        .HasColumnType("date");

                    b.Property<string>("orders_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orders_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipping_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("customerId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Final_Project.Models.product_category", b =>
                {
                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.HasKey("category_id", "product_id");

                    b.HasIndex("product_id");

                    b.ToTable("products_category");
                });

            modelBuilder.Entity("Final_Project.Models.products", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("catgory_id")
                        .HasColumnType("int");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.Property<string>("thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Final_Project.Models.order_details", b =>
                {
                    b.HasOne("Final_Project.Models.orders", "order")
                        .WithMany("order_detail")
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_Project.Models.products", "products")
                        .WithMany("order_details")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("products");
                });

            modelBuilder.Entity("Final_Project.Models.orders", b =>
                {
                    b.HasOne("Final_Project.Models.customers", "customer")
                        .WithMany("order")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("Final_Project.Models.product_category", b =>
                {
                    b.HasOne("Final_Project.Models.categories", "categories")
                        .WithMany("product_category")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_Project.Models.products", "products")
                        .WithMany("product_category")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categories");

                    b.Navigation("products");
                });

            modelBuilder.Entity("Final_Project.Models.categories", b =>
                {
                    b.Navigation("product_category");
                });

            modelBuilder.Entity("Final_Project.Models.customers", b =>
                {
                    b.Navigation("order");
                });

            modelBuilder.Entity("Final_Project.Models.orders", b =>
                {
                    b.Navigation("order_detail");
                });

            modelBuilder.Entity("Final_Project.Models.products", b =>
                {
                    b.Navigation("order_details");

                    b.Navigation("product_category");
                });
#pragma warning restore 612, 618
        }
    }
}
