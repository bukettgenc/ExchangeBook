﻿// <auto-generated />
using ExchangeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExchangeBook.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
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

            modelBuilder.Entity("ExchangeBook.Models.MyBook", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookAuthor");

                    b.Property<string>("BookName");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("TypeId");

                    b.Property<int>("UserId");

                    b.HasKey("BookId");

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

                    b.Property<string>("Email");

                    b.Property<string>("Image");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ExchangeBook.Models.MyBook", b =>
                {
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

            modelBuilder.Entity("ExchangeBook.Models.Review", b =>
                {
                    b.HasOne("ExchangeBook.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}