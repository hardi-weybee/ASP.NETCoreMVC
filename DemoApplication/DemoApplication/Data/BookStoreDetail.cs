using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApplication.Models;

namespace DemoApplication.Data
{
    public class BookStoreDetail : DbContext
    {
        public BookStoreDetail(DbContextOptions<BookStoreDetail> options)
            : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        public DbSet<Language> Language { get; set; }

        public DbSet<BookGallery> BookGallery { get; set; }
    }
}
