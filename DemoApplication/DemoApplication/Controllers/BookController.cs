using DemoApplication.Models;
using DemoApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository = null;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = bookRepository.GetAllBooks();

            return View();
        }

        public BookModel GetBook(int id)
        {
            return bookRepository.GetBookByID(id);
        }

        public List<BookModel> SearchBook(string name, string authorName)
        {
            return bookRepository.SearchBook(name, authorName);
        }
    }
}
