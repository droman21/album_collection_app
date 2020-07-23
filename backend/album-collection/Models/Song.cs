using album_collection.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace album_collection.Models
{
    public class Song
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int AlbumID { get; set; }
        public string SongDuration { get; set; }

 
        public virtual Album album { get; set; }

        public Song()
        { }

        public Song(string name, int songID, int albumID, string songDuration)
        {

            this.Name = name;
            this.ID = songID;
            this.AlbumID = albumID;
            this.SongDuration = songDuration;


        }


    }
}
