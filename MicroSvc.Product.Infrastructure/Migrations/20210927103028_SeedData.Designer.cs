﻿// <auto-generated />
using System;
using MicroSvc.Product.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroSvc.Product.Infrastructure.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20210927103028_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("MicroSvc.Product.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ee217de5-2294-403c-b123-9bbbfaf4e1c4"),
                            Company = "The Caco-cala ltd",
                            Name = "Caco-cala",
                            Stock = 9000
                        },
                        new
                        {
                            Id = new Guid("0935b6a7-28bf-4d1b-9244-e7db08d165b9"),
                            Company = "Indiemie ltd",
                            Name = "Indie-mie",
                            Stock = 1500
                        },
                        new
                        {
                            Id = new Guid("9ebe44e1-b6ae-4db0-8a08-aa7f3046888d"),
                            Company = "PT Torubaka",
                            Name = "Galus Mix",
                            Stock = 756
                        },
                        new
                        {
                            Id = new Guid("290facd3-7a48-4d8b-820d-00015ea9c9aa"),
                            Company = "PT Sehat walafiat",
                            Name = "Katas-Katas",
                            Stock = 75
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
