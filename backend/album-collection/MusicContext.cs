﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using album_collection.Models;

namespace album_collection
{

    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicDatabase;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Artist>().HasData(


               new Artist("Machine Gun Kelly", 1, "Image", 30, "Bad Boy Records", "Cleveland, OH"),
               new Artist("Big Moochie Grape", 2, "Image", 29, "Paper Route EMPIRE", "Memphis, TN"),
               new Artist("Isaiah Rashad", 3, "IsaiahRashad.jpg", 29, "Top Dawg Entertainment", "Chattanooga, TN"),
               new Artist("Beyonce", 4, "Beyonce.jpg", 38, "Parkwood", "Houston, TX"),
               new Artist("Billie Eilish", 5, "BillieEilish.jpg", 18, "Interscope Records", "Los Angeles, CA"),
               new Artist("Drake", 6, "Drake.jpg", 33, "OVO Sound", "Toronto, Canada")

               );

            modelbuilder.Entity<Album>().HasData(


                new Album("Hotel Diablo", 1, "MGK.jpg", "Bad Boy Records", 1),
                new Album("Eat or Get Ate", 2, "BigMoochie.jpg", "Paper Route Empire", 2),
                new Album("The Sun's Tirade", 3, "SunsTirade.jpg", "Top Dawg Entertainment", 3),
                new Album("Lemonade", 4, "Lemonade. jpg", "Parkwood", 4),
                new Album("Don't Smile At Me", 5, "DontSmileAtMe.jpg", "Interscope Records", 5),
                new Album("When We All Fall Aleep, Where Do We Go?", 6, "wwafawdwg.jpg", "Interscope Records", 5),
                new Album("Views", 7, "Views.jpg", "OVO Sound", 6),
                new Album("If You're Reading This It's Too Late", 8, "iyrtitl.jpg", "OVO Sound", 6),
                new Album("Scorpion", 9, "Scorpion.jpg", "OVO Sound", 6),
                new Album("Cilvia Demo", 10, "CilviaDemo.jpg", "Top Dawg Entertainment", 3)

                );

        }
    }
}
