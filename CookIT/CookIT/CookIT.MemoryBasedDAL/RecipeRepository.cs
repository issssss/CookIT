using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using CookIT.Model;
using CookIT.Model.Repositories;
using CookIT.Model.Factories;

namespace CookIT.MemoryBasedDAL
{
    public class RecipeRepository : IRecipeRepository
    {
        private static int _nextID = 1;
        private static RecipeRepository _instance;

        private readonly List<Recipe> _listRecipes = new List<Recipe>();
        private readonly List<Recipe> _toMakeRecipes = new List<Recipe>();

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

        public void addToMakeRecipe(int ID)
        {
            Recipe rec = getRecipeByID(ID);
            // provjeriti da li već postoji recount s tim imenom
            if (_toMakeRecipes.Any(r => r.Name == rec.Name))
            {

                throw new RecipeAlreadyExists();
            }

            _toMakeRecipes.Add(rec);


        }

        public void removeToMakeRecipe(int recID)
        {
            Recipe toRemove = this.getRecipeByID(recID);
            this._toMakeRecipes.Remove(toRemove);
        }

        public List<Recipe> getAllToMakeRecipes()
        {
            return _toMakeRecipes;
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
            try
            {
                var rec = (from l in _listRecipes where l.Id == inRecID select l).First();
                return rec;
            }
            catch (Exception e)
            {
                throw new RecipeDoesntExist();
            }
        }

        public Recipe getRecipeByName(string recName)
        {
            try
            {
                var rec = (from l in _listRecipes where l.Name == recName select l).First();
                return rec;
            }
            catch (Exception e)
            {
                throw new RecipeDoesntExist();
            }
            
            
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

        public void editRecipe(int ID, string edRec, string grade)
        {
            Recipe oldRecipa = getRecipeByID(ID);
            deleteRecipe(ID);
            string type = RecipeTypesList.RecTypeDict[oldRecipa.Type];
            Recipe editedRecipe = RecipeFactory.CreateRecipe(ID, oldRecipa.Name, type, oldRecipa.Ingredients, edRec, oldRecipa.IngredientsList, grade);
            this._listRecipes.Add(editedRecipe);
        }

        public float calculateSumOfCalories(int ID)
        {
            float sum = 0;
            Recipe recipe = getRecipeByID(ID);
            IngredientRepository ingrep = IngredientRepository.getInstance();
            foreach (string ing in recipe.Ingredients.Keys)
            {
                Ingredient ingred = ingrep.getIngredientByName(ing);
                sum += ingred.Kcal;
            }
            return sum/recipe.Ingredients.Keys.Count;
        }

        public int getRecommendation(string typeOfRecipe, string ingredient)
        {
            
            Random _random = new Random();

            if (typeOfRecipe == "" && ingredient == "") return _listRecipes[_random.Next(0, (_listRecipes.Count - 1))].Id;

            List<Recipe> toChooseFrom = new List<Recipe>();
            for(int i = 0; i < _listRecipes.Count; i++)
            {
                Recipe recipe = _listRecipes[i];
                if (typeOfRecipe != "")
                {
                    if(RecipeTypesList.RecTypeDict[recipe.Type] == typeOfRecipe)
                    {
                        if (ingredient != "" && !recipe.Ingredients.ContainsKey(ingredient)) continue;
                        toChooseFrom.Add(recipe);
                    }
                }
                else if(ingredient != "")
                {
                    if (recipe.Ingredients.ContainsKey(ingredient)) toChooseFrom.Add(recipe);
                }

            }
            if(toChooseFrom.Count > 0)
            {
                int randInd = _random.Next(0, (toChooseFrom.Count - 1));
                return toChooseFrom[randInd].Id;
            }
            return -1;
        }
    }
}
