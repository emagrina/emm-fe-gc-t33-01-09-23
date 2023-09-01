﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ex01.Data;

#nullable disable

namespace ex01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230901130630_AddModelsArticuloYFabricante")]
    partial class AddModelsArticuloYFabricante
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ex01.Models.Articulo", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FabricanteCodigo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.HasIndex("FabricanteCodigo");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("ex01.Models.Fabricante", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Codigo");

                    b.ToTable("Fabricantes");
                });

            modelBuilder.Entity("ex01.Models.Articulo", b =>
                {
                    b.HasOne("ex01.Models.Fabricante", "Fabricante")
                        .WithMany("Articulos")
                        .HasForeignKey("FabricanteCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fabricante");
                });

            modelBuilder.Entity("ex01.Models.Fabricante", b =>
                {
                    b.Navigation("Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}
