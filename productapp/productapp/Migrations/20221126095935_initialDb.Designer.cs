﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using productapp.Context;

namespace productapp.Migrations
{
    [DbContext(typeof(productDbcontext))]
    [Migration("20221126095935_initialDb")]
    partial class initialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("productapp.Models.Product", b =>
                {
                    b.Property<long>("MASANPHAM")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(7)
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<float>("GIABAN")
                        .HasColumnType("real");

                    b.Property<DateTime>("HANSUDUNG")
                        .HasColumnType("datetime2");

                    b.Property<string>("NHASANXUAT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TENSANPHAM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MASANPHAM");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
