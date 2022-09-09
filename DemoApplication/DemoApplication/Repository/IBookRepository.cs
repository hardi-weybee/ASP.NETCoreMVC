using DemoApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoApplication.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookByID(int id);
        Task<List<BookModel>> GetTopBooksAsync(int count);
        List<BookModel> SearchBook(string title, string authorName);

        //string GetAppName();
    }
}