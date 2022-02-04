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
    public class RecipeController: IRecipeController
    {

        public void AddNewRecipe(IAddNewRecipeView inForm, IRecipeRepository recipeRepository, IIngredientRepository ingredientRep)
        {
            if (inForm.ShowModalView() == true)
            {
                try
                {
                    string Name = inForm.RecipeName;
                    string RecType = inForm.RecipeType;
                    string RecText = inForm.RecipeText;
                    Dictionary<string, string> RecIngredients = inForm.RecipeIngred; //new List<int> { 1, 2, 3 };
                    Debug.WriteLine(RecIngredients.Count);
                    int ID = recipeRepository.getNewId();
                    List<Ingredient> ingredients = new List<Ingredient>();
                    foreach (string name in RecIngredients.Keys)
                        ingredients.Add(ingredientRep.getIngredientByName(name));
                    Recipe newRecipe = RecipeFactory.CreateRecipe(ID, Name, RecType, RecIngredients, RecText, ingredients, "");
                    recipeRepository.addRecipe(newRecipe);
                }
                catch (Exception ex)
                {
                    if(ex is RecipeAlreadyExists)
                        MessageBox.Show("The name of the recipe already exists.");
                    else if(ex is NullReferenceException)
                        MessageBox.Show("Choose ingredients and their quantity.");
                    AddNewRecipe(inForm, recipeRepository, ingredientRep);
      
                    //throw;
                    return; 
                }
            }
        }

        public void ShowRecipes(IViewRecipesView viewRecipes, IRecipeRepository rep, IMainFormController cont)
        {

            viewRecipes.ShowModaless(cont, rep.GetAllRecipes());
        }

        public void ShowRecipe(int ID, IShowRecipe showRec, IRecipeRepository rep, IMainFormController cont)
        {
            showRec.showRecipe(ID, cont, rep.getRecipeByID(ID));
        }

        public void DeleteRecipe(int ID, IRecipeRepository rep)
        {
            rep.deleteRecipe(ID);
        }

        public void EditRecipe(int ID, string text, string grade, IRecipeRepository rep)
        {
            
            rep.editRecipe(ID, text, grade);
        }
        public void GetIngredientQuant(IAddNewRecipeView view, IAddIngredientQuantityView ingQuanView, List<string> ingredients, IMainFormController cont)
        {
            ingQuanView.ShowModaless(view,ingredients, cont);
        }

        public void GetQuantityforRecipe(IAddNewRecipeView recipeView, Dictionary<string, string> quantity)
        {
            recipeView.SaveQuantity(quantity);
        }

        public void GetRecipeRecommentadion(IChooseForRecommendationView inForm, IRecipeRepository recipeRepository, IShowRecipe recipe, IMainFormController cont)
        {
            if(inForm.ShowModalView() == true)
            {
                try
                {
                    int ID = recipeRepository.getRecommendation(inForm.Type, inForm.Ingredient);
                    if (ID == -1)
                        MessageBox.Show("There is no recipe with those requirements. Try again.");
                    else
                    {
                        recipe.showRecipe(ID, cont, recipeRepository.getRecipeByID(ID));
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("The values are incorrect, sorry.");
                }
            }
        }

        public void ShowToMakeList(IShowToMakeView inForm, IRecipeRepository rep, IMainFormController controller)
        {
            inForm.ShowModaless(controller, rep.getAllToMakeRecipes());

        }

        public void AddRecipeToMakeList(int ID,IRecipeRepository rep)
        {
            try
            {
                rep.addToMakeRecipe(ID);
            }catch(Exception e)
            {
                MessageBox.Show("The recipe is already in the list.");
            }
        }

        public void RemoveFromToMakeList(int ID, IRecipeRepository rep)
        {
            
            rep.removeToMakeRecipe(ID);
        }
    }
}
