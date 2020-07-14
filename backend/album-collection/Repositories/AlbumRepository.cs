using album_collection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Repositories
{
    public class AlbumRepository : Repository<Album>, IRepository<Album>
    {
        public AlbumRepository(MusicContext context) : base(context)
        {

        }

        public void Update(Artist artist)
        {
            throw new NotImplementedException();
        }
    }
}
