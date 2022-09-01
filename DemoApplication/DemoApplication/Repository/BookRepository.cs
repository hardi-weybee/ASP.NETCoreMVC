using DemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookByID(int id)
        {
            return DataSource().Where(x => x.ID == id).FirstOrDefault(); 
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ ID =1, Title="Java", Author="Hardi"},
                new BookModel(){ ID =2, Title="MVC", Author="Kakashi"},
                new BookModel(){ ID =3, Title="C#", Author="Emma"},
                new BookModel(){ ID =4, Title="PHP", Author="Charlie"},
                new BookModel(){ ID =5, Title="DBMS", Author="Chandler"},
            };
        }
    }
}
