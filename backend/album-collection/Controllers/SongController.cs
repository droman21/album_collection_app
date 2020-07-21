using album_collection.Models;
using album_collection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace album_collection.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {

        IRepository<Song> songRepo;

        public SongController(IRepository<Song> songRepo)
        {

            this.songRepo = songRepo;


        }


        //Get: api/Song
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songRepo.GetAll();
        }

        // GET: api/Owner/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return songRepo.GetById(id);
        }

        // POST: api/Song
        [HttpPost]
        public IEnumerable<Song> Post([FromBody] Song value)
        {
            songRepo.Create(value);
            return songRepo.GetAll();
        }

        // PUT: api/Owner/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {



        }

    }
}
