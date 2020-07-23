using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using album_collection.Models;
using album_collection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace album_collection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {


        private album_collection.Repositories.IRepository<Artist> artistRepo;

        public ArtistController(IRepository<Artist> otherRepo)
        {

            this.artistRepo = otherRepo;

        }
        
        
        
        // GET: api/<ArtistController>
        [HttpGet]
        public IEnumerable<Models.Artist> Get()
        {
            return this.artistRepo.GetAll();
        }

        // GET api/<ArtistController>/5
        [HttpGet("{id}")]
        public Artist Get(int id)
        {
            Artist artist = artistRepo.GetById(id);
            return artist;
            //return artistRepo.GetById(id);
        }

        // POST api/<ArtistController>
        [HttpPost]
        public IEnumerable<Artist> Post([FromBody] Artist value)
        {
            artistRepo.Create(value);
            return artistRepo.GetAll();
        }

        // PUT api/<ArtistController>/5
        [HttpPut("{id}")]
        public IEnumerable<Artist> Put([FromBody] Artist value)
        {
            artistRepo.Update(value);
            return artistRepo.GetAll();
        }

        // DELETE api/<ArtistController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Artist> Delete(int id)
        {
            var artist = artistRepo.GetById(id);
            artistRepo.Delete(artist);
            return artistRepo.GetAll();
        }
    }
}
