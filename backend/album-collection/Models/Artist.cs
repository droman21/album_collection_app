using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Artist
    {
        public int ID { get; set; }
        public string ArtistName { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public string RecordLabel { get; set; }
        public string HomeTown { get; set; }


        public virtual IEnumerable<Album> Albums { get; set; }

        public Artist()
        {

        }
        public Artist(string name, int id, string image, int age, string recordLabel, string homeTown)
        {
            ArtistName = name;
            ID = id;
            Image = image;
            Age = age;
            RecordLabel = recordLabel;
            HomeTown = homeTown;

        }
    }
}
