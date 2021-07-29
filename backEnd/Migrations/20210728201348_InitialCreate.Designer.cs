﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backEnd.Models;

namespace backEnd.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210728201348_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backEnd.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("DetailId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublicDay")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DetailId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("backEnd.Models.BookBorrowingRequest", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BorrowerId")
                        .HasColumnType("int");

                    b.Property<int>("DetailId")
                        .HasColumnType("int");

                    b.Property<int>("RepondentId")
                        .HasColumnType("int");

                    b.Property<string>("RepondentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestId");

                    b.HasIndex("DetailId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("BookBorrowingRequests");
                });

            modelBuilder.Entity("backEnd.Models.BookBorrowingRequestDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.ToTable("BookBorrowingRequestDetails");
                });

            modelBuilder.Entity("backEnd.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Catrgories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action"
                        });
                });

            modelBuilder.Entity("backEnd.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookBorrowingRequestId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("_isAdmin")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            BookBorrowingRequestId = 0,
                            IsAdmin = true,
                            Name = "Admin",
                            Password = "admin",
                            _isAdmin = true
                        },
                        new
                        {
                            UserId = 2,
                            BookBorrowingRequestId = 0,
                            IsAdmin = false,
                            Name = "D2efault",
                            Password = "123qwe",
                            _isAdmin = false
                        });
                });

            modelBuilder.Entity("backEnd.Models.Book", b =>
                {
                    b.HasOne("backEnd.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backEnd.Models.BookBorrowingRequestDetail", "Detail")
                        .WithMany("Books")
                        .HasForeignKey("DetailId");

                    b.Navigation("Category");

                    b.Navigation("Detail");
                });

            modelBuilder.Entity("backEnd.Models.BookBorrowingRequest", b =>
                {
                    b.HasOne("backEnd.Models.BookBorrowingRequestDetail", "Detail")
                        .WithOne("Request")
                        .HasForeignKey("backEnd.Models.BookBorrowingRequest", "DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backEnd.Models.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId");

                    b.Navigation("Detail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("backEnd.Models.BookBorrowingRequestDetail", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("backEnd.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("backEnd.Models.User", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}