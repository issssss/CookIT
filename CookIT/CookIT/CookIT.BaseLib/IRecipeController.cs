using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;

namespace CookIT.BaseLib
{
    public interface IRecipeController
    {
        void AddNewRecipe(IAddNewRecipeView inForm, IRecipeRepository recipeRepository, IIngredientRepository ingredientRep);

        void ShowRecipes(IViewRecipesView viewRecipes, IRecipeRepository rep, IMainFormController cont);
        void ShowRecipe(int ID, IShowRecipe showRec, IRecipeRepository rep, IMainFormController cont);

        void DeleteRecipe(int ID, IRecipeRepository rep);

        void EditRecipe(int ID, string text, string grade, IRecipeRepository rep);
        void GetQuantityforRecipe(IAddNewRecipeView recipeView, Dictionary<string, string> quantity);
        void ShowToMakeList(IShowToMakeView inForm, IRecipeRepository rep, IMainFormController controller);
        void GetRecipeRecommentadion(IChooseForRecommendationView inForm, IRecipeRepository recipeRepository, IShowRecipe recipe, IMainFormController cont);
        void AddRecipeToMakeList(int ID, IRecipeRepository rep);
        void RemoveFromToMakeList(int ID, IRecipeRepository rep);
        void GetIngredientQuant(IAddNewRecipeView view, IAddIngredientQuantityView ingQuanView, List<string> ingredients, IMainFormController cont);

    }
   


}

