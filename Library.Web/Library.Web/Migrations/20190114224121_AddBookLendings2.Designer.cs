﻿// <auto-generated />
using System;
using Library.Web.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Web.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190114224121_AddBookLendings2")]
    partial class AddBookLendings2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Library.Web.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("OwnerId");

                    b.HasKey("BookId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library.Web.Entities.BookLending", b =>
                {
                    b.Property<int>("BookLendingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<DateTime>("DateFrom");

                    b.Property<DateTime>("DateTo");

                    b.Property<int>("OwnerId");

                    b.HasKey("BookLendingId");

                    b.HasIndex("BookId");

                    b.HasIndex("OwnerId");

                    b.ToTable("BookLendings");
                });

            modelBuilder.Entity("Library.Web.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Library.Web.Entities.Book", b =>
                {
                    b.HasOne("Library.Web.Entities.User", "Owner")
                        .WithMany("Books")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Web.Entities.BookLending", b =>
                {
                    b.HasOne("Library.Web.Entities.Book", "Book")
                        .WithMany("BookLendings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Web.Entities.User", "Owner")
                        .WithMany("BookLendings")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
