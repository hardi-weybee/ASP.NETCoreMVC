using DemoApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoApplication.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}