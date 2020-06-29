﻿// <auto-generated />
using System;
using AutoParts4Sale.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoParts4Sale.Data.Migrations
{
    [DbContext(typeof(AutoParts4SaleDbContexts))]
    [Migration("20200616183810_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoParts4Sale.Core.Autopart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarMakeId")
                        .HasColumnType("int");

                    b.Property<int?>("CarModelId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarMakeId");

                    b.HasIndex("CarModelId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Autoparts");
                });

            modelBuilder.Entity("AutoParts4Sale.Core.CarMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearMade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CarMake");
                });

            modelBuilder.Entity("AutoParts4Sale.Core.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarModel");
                });

            modelBuilder.Entity("AutoParts4Sale.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AutoParts4Sale.Core.Autopart", b =>
                {
                    b.HasOne("AutoParts4Sale.Core.CarMake", "CarMake")
                        .WithMany()
                        .HasForeignKey("CarMakeId");

                    b.HasOne("AutoParts4Sale.Core.CarModel", "CarModel")
                        .WithMany()
                        .HasForeignKey("CarModelId");

                    b.HasOne("AutoParts4Sale.Core.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}