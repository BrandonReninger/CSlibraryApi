using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi
{

    [ApiController]
    [Route("api/[controller]")]
    public class VideoGamesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VideoGame>> GetAll()
        {
            try
            {
                return Ok(FakeDB.VideoGames);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{videogameId}")]
        public ActionResult<IEnumerable<VideoGame>> GetOne(string videogameId)
        {
            try
            {
                VideoGame foundVideoGame = FakeDB.VideoGames.Find(videogame => videogame.Id == videogameId);
                if (foundVideoGame == null)
                {
                    throw new Exception("Invalid Id!");
                }
                return Ok(foundVideoGame);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<IEnumerable<VideoGame>> Create([FromBody] VideoGame newVideoGame)
        {
            try
            {
                FakeDB.VideoGames.Add(newVideoGame);
                return Created($"api/videogame/{newVideoGame.Id}", newVideoGame);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(string id)
        {
            try
            {
                VideoGame vgToDelete = FakeDB.VideoGames.Find(v => v.Id == id);
                if (vgToDelete == null)
                {
                    throw new Exception("Invalid Id!");
                }
                FakeDB.VideoGames.Remove(vgToDelete);
                return Ok("Wiedersehen!");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]
        public ActionResult<VideoGame> Edit(string id, [FromBody] VideoGame updateVideoGame)
        {
            try
            {
                VideoGame videogameToUpdate = FakeDB.VideoGames.Find(v => v.Id == id);
                if (videogameToUpdate == null)
                {
                    throw new Exception("Invalid Id!");
                }
                videogameToUpdate.Title = updateVideoGame.Title == null ? videogameToUpdate.Title : updateVideoGame.Title;
                videogameToUpdate.Platform = updateVideoGame.Platform == null ? videogameToUpdate.Platform : updateVideoGame.Platform;
                videogameToUpdate.Rating = updateVideoGame.Rating == null ? videogameToUpdate.Rating : updateVideoGame.Rating;
                videogameToUpdate.Price = updateVideoGame.Price;

                return Ok(videogameToUpdate);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }

        }

    }
}