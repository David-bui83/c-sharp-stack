﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chef.Models;

namespace chef.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190819033047_chefDishes")]
    partial class chefDishes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("chef.Models.Chef", b =>
                {
                    b.Property<int>("ChefId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DOB")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("ChefId");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("chef.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Calories")
                        .IsRequired();

                    b.Property<int>("ChefId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("DishName")
                        .IsRequired();

                    b.Property<int?>("Tastiness")
                        .IsRequired();

                    b.HasKey("DishId");

                    b.HasIndex("ChefId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("chef.Models.Dish", b =>
                {
                    b.HasOne("chef.Models.Chef", "Creator")
                        .WithMany("CreateDishes")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
