﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaisesInfoAPI.Models;

#nullable disable

namespace PaisesInfoAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PaisesInfoAPI.Models.PaisData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("capital")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("codigoPostal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("continente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("idioma")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("indicativoTelefonia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("moneda")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("zonahoraria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("PaisesData");
                });
#pragma warning restore 612, 618
        }
    }
}
