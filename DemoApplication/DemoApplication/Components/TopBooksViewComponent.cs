using DemoApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Components
{
    public class TopBooksViewComponent : ViewComponent
    {
        private readonly IBookRepository bookRepository;
        public TopBooksViewComponent(IBookRepository repository1)
        {
            bookRepository = repository1;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var books = await bookRepository.GetTopBooksAsync(count);
            return View(books);
        }
    }
}
