using album_collection.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Album
    {
        public int ID { get; set; }

        public int ArtistID { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public string Label { get; set; }

        [JsonIgnore]
        public virtual Artist artist { get; set; }

        public Album()
        {

        }

        public Album(string title, int id, string image, string label, int artistID)
        {
            Title = title;
            ID = id;
            Image = image;
            Label = label;
            ArtistID = artistID;


        }
    }
}
