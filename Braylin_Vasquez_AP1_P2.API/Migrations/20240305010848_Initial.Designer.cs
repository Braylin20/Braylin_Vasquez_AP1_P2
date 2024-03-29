﻿// <auto-generated />
using System;
using Braylin_Vasquez_AP1_P2.API.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Braylin_Vasquez_AP1_P2.API.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240305010848_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Shared.Models.Accesorios", b =>
                {
                    b.Property<int>("AccesoriosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("AccesoriosId");

                    b.ToTable("Accesorios");

                    b.HasData(
                        new
                        {
                            AccesoriosId = 1,
                            Descripcion = "Camara Trasera"
                        },
                        new
                        {
                            AccesoriosId = 2,
                            Descripcion = "Pantalla Inferior"
                        },
                        new
                        {
                            AccesoriosId = 3,
                            Descripcion = "Interior Trasera"
                        });
                });

            modelBuilder.Entity("Shared.Models.Vehiculos", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Fecha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Gastos")
                        .HasColumnType("REAL");

                    b.HasKey("VehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Shared.Models.VehiculosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccesorioId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.ToTable("VehiculosDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
