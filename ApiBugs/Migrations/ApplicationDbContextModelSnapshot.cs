﻿// <auto-generated />
using System;
using ApiBugs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiBugs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiBugs.Models.bugModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("App")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Atiende")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaReporte")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pantalla")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plataforma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prioridad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reporta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resumen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Severidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SistemaOperativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BugsDb");
                });
#pragma warning restore 612, 618
        }
    }
}
