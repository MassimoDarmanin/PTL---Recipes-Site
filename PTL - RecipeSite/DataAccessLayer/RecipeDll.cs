using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using GE = Global.Entity;

namespace DataAccessLayer
{
    public class RecipeDll : IRecipe
    {
        private readonly PtlrecipesContext _recipesContext;
        public RecipeDll(PtlrecipesContext ptlrecipesContext)
        {
            _recipesContext = ptlrecipesContext;
        }

        public List<GE::RecipeGlobal> GetRecipes()
        {
            //return _recipesContext.Recipes.ToList();
            var _data = _recipesContext.Recipes.ToList();
            List<GE::RecipeGlobal> _recipes = new List<GE::RecipeGlobal>();
            if( _data != null && _data.Count > 0)
            {
                _data.ForEach(item =>
                {
                    _recipes.Add(new GE.RecipeGlobal
                    {
                        RecipeId = item.RecipeId,
                        UserId = item.UserId,
                        Title = item.Title,
                        Instructions = item.Instructions,
                        //User = item.User
                    });
                });
            }
            return _recipes;
        }
    }
}
