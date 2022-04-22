﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeXuanVinh.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("LeXuanVinh.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("LeXuanVinh.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NewsID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("NewsID");

                    b.ToTable("Comment", (string)null);
                });

            modelBuilder.Entity("LeXuanVinh.Models.News", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("News", (string)null);
                });

            modelBuilder.Entity("LeXuanVinh.Models.Comment", b =>
                {
                    b.HasOne("LeXuanVinh.Models.News", null)
                        .WithMany("Comments")
                        .HasForeignKey("NewsID");
                });

            modelBuilder.Entity("LeXuanVinh.Models.News", b =>
                {
                    b.HasOne("LeXuanVinh.Models.Category", "Category")
                        .WithMany("News")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LeXuanVinh.Models.Category", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("LeXuanVinh.Models.News", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
