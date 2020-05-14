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

    }
}