using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model.Repositories
{
    public interface IRecipeRepository
    {
        int getNewId();
        Recipe getRecipeByID(int inRecID);
        Recipe getRecipeByName(string recName);

        List<int> getAllRecipeIDs();
        List<String> GetAllRecipeNames();
        List<Recipe> GetAllRecipes();
        void addRecipe(Recipe addRec);

        void deleteRecipe(int recID);

        void editRecipe(int ID, string text, string grade);

        float calculateSumOfCalories(int ID);
        int getRecommendation(string typeOfRecipe, string ingredient);
        void addToMakeRecipe(int ID);
        void removeToMakeRecipe(int recID);
        List<Recipe> getAllToMakeRecipes();

    }
}
