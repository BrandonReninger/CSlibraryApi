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
                return BadRequest(err.Message);
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
                return BadRequest(err.Message);
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
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(string id)
        {
            try
            {
                Book bookBeGone = FakeDB.Books.Find(b => b.Id == id);
                if (bookBeGone == null)
                {
                    throw new Exception("Invalid Id");
                }
                FakeDB.Books.Remove(bookBeGone);
                return Ok("Deleted!");
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Book> Edit(string id, [FromBody] Book updatedBook)
        {
            try
            {
                Book bookToUpdate = FakeDB.Books.Find(b => b.Id == id);
                if (bookToUpdate == null)
                {
                    throw new Exception("Invalid Id");
                }
                //NOTE add the needed logic if this wasn't a required field
                bookToUpdate.Title = updatedBook.Title;
                bookToUpdate.Author = updatedBook.Author;
                //bookToUpdate.Available = updatedBook.Available;
                return Ok(bookToUpdate);
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

    }
}