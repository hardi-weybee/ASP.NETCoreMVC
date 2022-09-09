using DemoApplication.Data;
using DemoApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreDetail _context = null;

        public BookRepository(BookStoreDetail context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                LanguageID = model.LanguageID,
                TotalPages = model.TotalPages.HasValue ? model.TotalPages.Value : 0,
                UpdatedOn = DateTime.UtcNow,
                CoverImageUrl = model.CoverImageUrl,
                BookPdfUrl = model.BookPdfUrl
            };

            newBook.BookGallery = new List<BookGallery>();
            foreach (var file in model.Gallery)
            {
                newBook.BookGallery.Add(new BookGallery()
                {
                    Name = file.Name,
                    URL = file.URL
                });
            }

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.ID;
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            return await _context.Books.Select(book => new BookModel()
            {
                Author = book.Author,
                Category = book.Category,
                Description = book.Description,
                LanguageID = book.LanguageID,
                //Language = book.Language?.Name ?? string.Empty,
                Language = book.Language.Name,
                Title = book.Title,
                TotalPages = book.TotalPages,
                ID = book.ID,
                CoverImageUrl = book.CoverImageUrl
            }).ToListAsync();
        }

        public async Task<List<BookModel>> GetTopBooksAsync(int count)
        {
            return await _context.Books.Select(book => new BookModel()
            {
                Author = book.Author,
                Category = book.Category,
                Description = book.Description,
                LanguageID = book.LanguageID,
                //Language = book.Language?.Name ?? string.Empty,
                Language = book.Language.Name,
                Title = book.Title,
                TotalPages = book.TotalPages,
                ID = book.ID,
                CoverImageUrl = book.CoverImageUrl
            }).Take(count).ToListAsync();
        }

        public async Task<BookModel> GetBookByID(int id)
        {
            return await _context.Books.Where(x => x.ID == id)
                .Select(book => new BookModel()
                {
                    Author = book.Author,
                    Category = book.Category,
                    Description = book.Description,
                    Title = book.Title,
                    TotalPages = book.TotalPages,
                    ID = book.ID,
                    LanguageID = book.LanguageID,
                    Language = book.Language.Name,
                    CoverImageUrl = book.CoverImageUrl,
                    Gallery = book.BookGallery.Select(x => new GalleryModel()
                    {
                        ID = x.ID,
                        Name = x.Name,
                        URL = x.URL
                    }).ToList(),
                    BookPdfUrl = book.BookPdfUrl
                }).FirstOrDefaultAsync();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return null;
        }

        //public string GetAppName()
        //{
        //    return "Bookish";
        //}
    }
}
