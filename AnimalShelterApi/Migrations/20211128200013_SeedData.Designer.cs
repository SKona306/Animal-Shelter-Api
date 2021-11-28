﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20211128200013_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Backstory")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 1,
                            Backstory = "Born recently with many siblings",
                            Gender = "Female",
                            Name = "Spark",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 2,
                            Backstory = "Raised by foster family",
                            Gender = "Male",
                            Name = "Boots",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 7,
                            Backstory = "Raised to believe she is a husky",
                            Gender = "Female",
                            Name = "Charlie",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 5,
                            Backstory = "Found running the streets of Portland",
                            Gender = "Female",
                            Name = "Kona",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 3,
                            Backstory = "Very generic Name not so generic puppy",
                            Gender = "Male",
                            Name = "Bob",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 9,
                            Backstory = "Saved from a traveling circus",
                            Gender = "Female",
                            Name = "Kyro",
                            Species = "Bird"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
