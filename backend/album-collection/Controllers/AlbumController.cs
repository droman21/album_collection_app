﻿using album_collection.Models;
using album_collection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace album_collection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        IRepository<Album> albumRepo;

        public AlbumController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        //Get: api/Album
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return albumRepo.GetAll();
        }

        // GET: api/Owner/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return albumRepo.GetById(id);
        }

        // POST: api/Artist
        [HttpPost]
        public IEnumerable<Album> Post([FromBody] Album value)
        {
            albumRepo.Create(value);
            return albumRepo.GetAll();
        }

        // PUT: api/Owner/5
        [HttpPut("{id}")]
        public IEnumerable<Album> Put([FromBody] Album value)
        {
            albumRepo.Update(value);
            return albumRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Album> Delete(int id)
        {
            Album album = albumRepo.GetById(id);
            if (album != null)
            {
                albumRepo.Delete(album);

            }
            return albumRepo.GetAll();

            //var album = albumRepo.GetById(id);
            //albumRepo.Delete(album);
            //return albumRepo.GetAll();

        }
    }
}
