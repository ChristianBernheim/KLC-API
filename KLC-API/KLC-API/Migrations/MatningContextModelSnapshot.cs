﻿// <auto-generated />
using System;
using KLC_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KLC_API.Migrations
{
    [DbContext(typeof(MatningContext))]
    partial class MatningContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KLC_API.Models.MatningNews2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Andningsfrekvens")
                        .HasColumnType("int");

                    b.Property<int?>("Medvetandegrad")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("Pulsfrekvens")
                        .HasColumnType("int");

                    b.Property<int?>("SyreMattnad")
                        .HasColumnType("int");

                    b.Property<int?>("SystolisktBlodtryck")
                        .HasColumnType("int");

                    b.Property<int?>("Temperatur")
                        .HasColumnType("int");

                    b.Property<DateTime>("TidForMatning")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TillfordSyrgas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MatningarNews2");
                });

            modelBuilder.Entity("KLC_API.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Personnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patienter");
                });
#pragma warning restore 612, 618
        }
    }
}
