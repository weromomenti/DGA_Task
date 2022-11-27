﻿// <auto-generated />
using Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221127213522_initialMig")]
    partial class initialMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "The Lord of the Rigns"
                        },
                        new
                        {
                            Id = 2,
                            Name = "The Hobiit"
                        });
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User 2"
                        });
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.Property<int>("WatchListId")
                        .HasColumnType("int");

                    b.Property<int>("WatchListUsersId")
                        .HasColumnType("int");

                    b.HasKey("WatchListId", "WatchListUsersId");

                    b.HasIndex("WatchListUsersId");

                    b.ToTable("MovieUser");
                });

            modelBuilder.Entity("MovieUser1", b =>
                {
                    b.Property<int>("ToWatchUsersId")
                        .HasColumnType("int");

                    b.Property<int>("WatchedMoviesId")
                        .HasColumnType("int");

                    b.HasKey("ToWatchUsersId", "WatchedMoviesId");

                    b.HasIndex("WatchedMoviesId");

                    b.ToTable("MovieUser1");
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.HasOne("Data.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("WatchListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("WatchListUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieUser1", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("ToWatchUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("WatchedMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}