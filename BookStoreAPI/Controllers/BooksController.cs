using BookStore.Data.Models;
using BookStore.Data.Repositories;
using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //public List<Book> books = new List<Book>()
        //{
        //    new Book {Id= 1, Title="Java", Author="Deepan", PublicationYear=2000, CallNumber="123", IsAvailable=false},
        //    new Book {Id= 2, Title=".Net", Author="Ramesh", PublicationYear=2001, CallNumber="234", IsAvailable=true},
        //    new Book {Id= 3, Title="React", Author="Robin", PublicationYear=2014, CallNumber="567", IsAvailable=true}
        //};

        public BookRepository books = new BookRepository();

        [HttpGet]
        public ActionResult<List<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            //var book = books.FirstOrDefault(x => x.Id == id);
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}
