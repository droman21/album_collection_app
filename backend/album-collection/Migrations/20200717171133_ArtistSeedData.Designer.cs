﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using album_collection;

namespace album_collection.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20200717171133_ArtistSeedData")]
    partial class ArtistSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("album_collection.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ArtistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 30,
                            ArtistName = "Machine Gun Kelly",
                            HomeTown = "Cleveland, OH",
                            Image = "Image",
                            RecordLabel = "Bad Boy Records"
                        },
                        new
                        {
                            ID = 2,
                            Age = 29,
                            ArtistName = "Big Moochie Grape",
                            HomeTown = "Memphis, TN",
                            Image = "Image",
                            RecordLabel = "Paper Route EMPIRE"
                        },
                        new
                        {
                            ID = 3,
                            Age = 29,
                            ArtistName = "Isaiah Rashad",
                            HomeTown = "Chattanooga, TN",
                            Image = "IsaiahRashad.jpg",
                            RecordLabel = "Top Dawg Entertainment"
                        },
                        new
                        {
                            ID = 4,
                            Age = 38,
                            ArtistName = "Beyonce",
                            HomeTown = "Houston, TX",
                            Image = "Beyonce.jpg",
                            RecordLabel = "Parkwood"
                        },
                        new
                        {
                            ID = 5,
                            Age = 18,
                            ArtistName = "Billie Eilish",
                            HomeTown = "Los Angeles, CA",
                            Image = "BillieEilish.jpg",
                            RecordLabel = "Interscope Records"
                        },
                        new
                        {
                            ID = 6,
                            Age = 33,
                            ArtistName = "Drake",
                            HomeTown = "Toronto, Canada",
                            Image = "Drake.jpg",
                            RecordLabel = "OVO Sound"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.HasOne("album_collection.Models.Artist", "artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}