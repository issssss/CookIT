using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using CookIT.Model;
using CookIT.Model.Repositories;

namespace CookIT.MemoryBasedDAL
{
    public class RecipeRepository : IRecipeRepository
    {
        private static int _nextID = 1;
        private static RecipeRepository _instance;

        private readonly List<Recipe> _listRecipes = new List<Recipe>();

        private RecipeRepository()
        {
           // _listRecipes.Add(new Recipe(getNewId()));
        }

        public static RecipeRepository getInstance()
        {
            return _instance ?? (_instance = new RecipeRepository());
        }

        public int getNewId()
        {
            int nextID = _nextID;

            _nextID++;

            return nextID;
        }
        public void addRecipe(Recipe addRec)
        {
            // provjeriti da li već postoji recount s tim imenom
            if (_listRecipes.Any(rec => rec.Name == addRec.Name))
            {
           
                throw new RecipeAlreadyExists();
            }

            // što ćemo s ID-jem?
            // provjeriti ćemo da li je neinicijaliziran ilii možda taj Id već postoji
            while (addRec.Id == Recipe.UndefinedRecipeID || _listRecipes.Any(rec => rec.Id == addRec.Id))
                addRec.Id = getNewId();                  // i redefinirati ga ako nije inicijaliziran

            _listRecipes.Add(addRec);
       

        }

        public void deleteRecipe(int recID)
        {
            Recipe toRemove = this.getRecipeByID(recID);
            this._listRecipes.Remove(toRemove);
        }

        public List<int> getAllRecipeIDs()
        {
            return _listRecipes.Select(rec => rec.Id).ToList();
        }

        public Recipe getRecipeByID(int inRecID)
        {
            var rec = (from l in _listRecipes where l.Id == inRecID select l).First();

            return rec;
        }

        public Recipe getRecipeByName(string recName)
        {
            var rec = (from l in _listRecipes where l.Name == recName select l).First();
            if (rec != null)
                return rec;
            throw new RecipeDoesntExist();
        }

        public List<int> getAllRecipeId()
        {
            return _listRecipes.Select(rec => rec.Id).ToList();
        }

        public List<string> GetAllRecipeNames()
        {
            return _listRecipes.Select(rec => rec.Name).ToList();
        }

        public List<Recipe> GetAllRecipes()
        {
            return _listRecipes;
        }

        public bool doesRecipeExist(Recipe arec)
        {
            return _listRecipes.Any(rec => rec.Name == arec.Name);
        }

        public void editRecipe(int ID, Recipe edRec)
        {
            Recipe toRemove = this.getRecipeByID(ID);
            this._listRecipes.Remove(toRemove);
            this._listRecipes.Add(edRec);
        }
    }
}
