using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using App.DAL.DataContext;
using App.DAL.Models;
using App.DAL.Repositories.Contracts;

namespace App.DAL.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly PTLRecipesContext _recipesContext;

        public GenericRepository(PTLRecipesContext pTLRecipesContext)
        {
            _recipesContext = pTLRecipesContext;
        }

        public async Task<List<TModel>> GetRecipes()
        {
            try
            {
                return await _recipesContext.Set<TModel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
