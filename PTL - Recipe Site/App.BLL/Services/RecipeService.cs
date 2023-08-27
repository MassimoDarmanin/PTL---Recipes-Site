using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.DAL.Models;
using App.DAL.Repositories.Contracts;
using App.BLL.Services.Contracts;

namespace App.BLL.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IGenericRepository<Recipe> _repository;

        public RecipeService(IGenericRepository<Recipe> repository)
        {
            _repository = repository;
        }

        public async Task<List<Recipe>> GetRecipes()
        {
            try
            {
                return await _repository.GetRecipes();
            }
            catch
            {
                throw;
            }
        }
    }
}
