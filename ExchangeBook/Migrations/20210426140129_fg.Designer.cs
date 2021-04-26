﻿// <auto-generated />
using System;
using ExchangeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExchangeBook.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210426140129_fg")]
    partial class fg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExchangeBook.Models.BookType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName");

                    b.HasKey("TypeId");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("ExchangeBook.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ExchangeBook.Models.MyBook", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookAuthor")
                        .IsRequired();

                    b.Property<string>("BookExplanation");

                    b.Property<string>("BookImage");

                    b.Property<string>("BookName")
                        .IsRequired();

                    b.Property<string>("CityId");

                    b.Property<int?>("CityId1");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("TypeId");

                    b.Property<int>("UserId");

                    b.HasKey("BookId");

                    b.HasIndex("CityId1");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("MyBooks");
                });

            modelBuilder.Entity("ExchangeBook.Models.MyFav", b =>
                {
                    b.Property<int>("FavId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<int>("UserId");

                    b.HasKey("FavId");

                    b.HasIndex("BookId");

                    b.ToTable("MyFavs");
                });

            modelBuilder.Entity("ExchangeBook.Models.Opinion", b =>
                {
                    b.Property<int>("OpinionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Published");

                    b.Property<int>("UserId");

                    b.Property<string>("YourOpinion")
                        .IsRequired();

                    b.HasKey("OpinionId");

                    b.HasIndex("UserId");

                    b.ToTable("Opinions");
                });

            modelBuilder.Entity("ExchangeBook.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Reviewer");

                    b.Property<string>("Reviews");

                    b.Property<int>("UserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ExchangeBook.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Password2");

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ExchangeBook.Models.MyBook", b =>
                {
                    b.HasOne("ExchangeBook.Models.City", "City")
                        .WithMany("MyBooks")
                        .HasForeignKey("CityId1");

                    b.HasOne("ExchangeBook.Models.BookType", "BookType")
                        .WithMany("MyBooks")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExchangeBook.Models.User", "User")
                        .WithMany("MyBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExchangeBook.Models.MyFav", b =>
                {
                    b.HasOne("ExchangeBook.Models.MyBook", "MyBook")
                        .WithMany("MyFavs")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExchangeBook.Models.Opinion", b =>
                {
                    b.HasOne("ExchangeBook.Models.User", "User")
                        .WithMany("Opinions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExchangeBook.Models.Review", b =>
                {
                    b.HasOne("ExchangeBook.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExchangeBook.Models.User", b =>
                {
                    b.HasOne("ExchangeBook.Models.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
