using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CookIT.Model;
using CookIT.Model.Factories;
using CookIT.Model.Repositories;
using CookIT.BaseLib;
using System.Diagnostics;

namespace CookIT.Controllers
{
    public class RecipeController
    {

        public void AddNewRecipe(IAddNewRecipeView inForm, IRecipeRepository recipeRepository)
        {
            if(inForm.ShowModalView() == true)
            {
                try
                {
                    string Name = inForm.RecipeName;
                    string RecType = inForm.RecipeType;
                    string RecText = inForm.RecipeText;
                    List<int> RecIngredients = inForm.RecipeIngred; //new List<int> { 1, 2, 3 };
                    Debug.WriteLine(RecIngredients.Count);
                    int ID = recipeRepository.getNewId();

                    Recipe newRecipe = RecipeFactory.CreateRecipe(ID, Name, RecType, RecIngredients, RecText);
                    recipeRepository.addRecipe(newRecipe);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                    throw;
                }
            }
        }

        public void ShowRecipes(IViewRecipesView viewRecipes, IRecipeRepository rep, IMainFormController cont)
        {
           
            viewRecipes.ShowModaless(cont, rep);
        }

        public void ShowRecipe(int ID,IShowRecipe showRec, IRecipeRepository rep, IIngredientRepository ing, IMainFormController cont)
        {
            showRec.showRecipe(ID, cont, rep, ing);
        }

        public void DeleteRecipe(int ID, IRecipeRepository rep)
        {
            rep.deleteRecipe(ID);
        }

        public void EditRecipe(int ID, Recipe recipe, IRecipeRepository rep)
        {
            rep.editRecipe(ID, recipe);
        }
    }
}
