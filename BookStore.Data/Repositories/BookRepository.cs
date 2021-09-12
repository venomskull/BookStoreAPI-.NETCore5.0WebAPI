using BookStore.Data.Interfaces;
using BookStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> books = new List<Book>()
        {
            new Book {Id= 1, Title="Java", Author="Deepan", PublicationYear=2000, CallNumber="123", IsAvailable=false},
            new Book {Id= 2, Title=".Net", Author="Ramesh", PublicationYear=2001, CallNumber="234", IsAvailable=true},
            new Book {Id= 3, Title="React", Author="Robin", PublicationYear=2014, CallNumber="567", IsAvailable=true}
        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
    }
}
