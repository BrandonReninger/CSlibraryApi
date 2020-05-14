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

        [HttpGet("{bookId}")]
        public ActionResult<IEnumerable<Book>> GetOne(string bookId)
        {
            try
            {
                Book foundBook = FakeDB.Books.Find(book => book.Id == bookId);
                if (foundBook == null)
                {
                    throw new Exception("Invalid Id");
                }
                return Ok(foundBook);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPost]
        public ActionResult<IEnumerable<Book>> Create([FromBody] Book newBook)
        {
            try
            {
                FakeDB.Books.Add(newBook);
                return Created($"api/books/{newBook.Id}", newBook);
            }
            catch (System.Exception err)
            {
                return BadRequest(err);
            }
        }

    }
}