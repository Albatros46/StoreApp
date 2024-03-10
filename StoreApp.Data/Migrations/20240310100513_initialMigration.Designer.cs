﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Data.Concrete;

#nullable disable

namespace StoreApp.Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20240310100513_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("StoreApp.Data.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Telefon",
                            Description = "Yeni nesil Iphone",
                            Name = "iPhone Pro 14 Pro",
                            Price = 1400m
                        },
                        new
                        {
                            Id = 2,
                            Category = "Tablet",
                            Description = "Digital not defteri",
                            Name = "reMarkable 3.0",
                            Price = 500m
                        },
                        new
                        {
                            Id = 3,
                            Category = "Tablet",
                            Description = "Digital not defteri",
                            Name = "reMarkable 2.0",
                            Price = 300m
                        },
                        new
                        {
                            Id = 4,
                            Category = "Laptop",
                            Description = "Laptop",
                            Name = "MacBook Pro",
                            Price = 3000m
                        },
                        new
                        {
                            Id = 5,
                            Category = "Laptop",
                            Description = "Yeni nesil Game Laptop",
                            Name = "Asus Rog Game ",
                            Price = 2700m
                        },
                        new
                        {
                            Id = 6,
                            Category = "Monitor",
                            Description = "Oyucnular icin hizli monitor",
                            Name = "NOC Bildschirm 21 Zoll",
                            Price = 485m
                        },
                        new
                        {
                            Id = 7,
                            Category = "TV",
                            Description = "OLED TV",
                            Name = "Samsung 65 inc TV",
                            Price = 1252m
                        },
                        new
                        {
                            Id = 8,
                            Category = "Elektrikli ev Aletleri",
                            Description = "Yeni nesil elektrikli süpürge",
                            Name = "Dyson 14",
                            Price = 250m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}