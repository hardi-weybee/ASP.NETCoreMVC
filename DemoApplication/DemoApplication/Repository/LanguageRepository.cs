using DemoApplication.Data;
using DemoApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly BookStoreDetail _context = null;

        public LanguageRepository(BookStoreDetail context)
        {
            _context = context;
        }

        public async Task<List<LanguageModel>> GetLanguages()
        {
            return await _context.Language.Select(x => new LanguageModel()
            {
                ID = x.ID,
                Description = x.Description,
                Name = x.Name
            }).ToListAsync();
        }
    }
}
