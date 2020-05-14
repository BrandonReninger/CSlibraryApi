using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace LibraryApi
{
    [ApiController]
    [Route("api/[controller]")]

    public class BooksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            try
            {
                return Ok(FakeDB.Books);
            }
            catch (Exception err)
            {
                return BadRequest(err);
            }
        }



    }
}