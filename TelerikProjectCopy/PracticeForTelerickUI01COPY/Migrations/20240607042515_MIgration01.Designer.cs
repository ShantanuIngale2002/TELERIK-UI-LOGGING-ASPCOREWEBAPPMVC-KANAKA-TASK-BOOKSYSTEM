﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticeForTelerickUI01.Repository.EFCore;

#nullable disable

namespace PracticeForTelerickUI01.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20240607042515_MIgration01")]
    partial class MIgration01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PracticeForTelerickUI01.Data.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("AddedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("added_on");

                    b.Property<string>("BookCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("book_code");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("book_name");

                    b.Property<string>("BookType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("book_type");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("PracticeForTelerickUI01.Data.BookInformation", b =>
                {
                    b.Property<int>("map_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("map_id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("author");

                    b.Property<string>("BookCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("book_code");

                    b.Property<int>("BorrowedCount")
                        .HasColumnType("int")
                        .HasColumnName("borrowed");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("total_stock");

                    b.HasKey("map_id");

                    b.ToTable("BooksInformation");
                });

            modelBuilder.Entity("PracticeForTelerickUI01.Models.BookCompleteDataModel", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<DateTime>("AddedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BorrowedCount")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalStock")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.ToTable("BookCompleteDataModel");
                });
#pragma warning restore 612, 618
        }
    }
}
