using album_collection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace album_collection.Repositories
{
    public class ArtistRepository : IRepository<Artist>
    {
        private MusicContext db;
        public ArtistRepository(MusicContext db)
        {
            this.db = db;
        }
        public IEnumerable<Artist> GetAll()
        {
            return db.Artists;
        }
        public Artist GetById(int id)
        {
            return db.Artists.Single(c => c.ID == id);
        }
        public int Count()
        {
            return db.Artists.Count();
        }
        public void Create(Artist artist)
        {
            db.Artists.Add(artist);
            db.SaveChanges();
        }
        public void Delete(Artist artist)
        {
            db.Artists.Remove(artist);
            db.SaveChanges();
        }
        public void Update(Artist artist)
        {
            db.Artists.Update(artist);
            db.SaveChanges();
        }
    }
}
