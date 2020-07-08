using System;
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


               new Artist("Machine Gun Kelly", 1, "Image", 30, "Cleveland Record Label", "Cleveland, OH"),
               new Artist("Big Moochie Grape", 2, "Image", 29, "Paper Route EMPIRE", "Memphis, TN")

               );

        }
    }
}
