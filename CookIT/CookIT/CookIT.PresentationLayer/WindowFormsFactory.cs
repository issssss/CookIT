using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.BaseLib;
using CookIT.Model;

namespace CookIT.PresentationLayer
{
	public class WindowFormsFactory : IWindowFormsFactory
	{

        public IAddNewIngredientView CreateAddIngredientView()
        {
            
            var newFrm = new frmAddIngredient();
            return newFrm;
        }

        public IAddNewRecipeView CreateAddNewRecipeView(List<string> inRecipeType, IMainFormController cont)
        {
			var newFrm = new frmAddRecipe(inRecipeType, cont);
			return newFrm;
        }

        public IAddIngredientQuantityView CreateIngredientsQuantityView()
        {
            var newFrm = new frmIngredientQuantity();
            return newFrm;
        }

        public IShowRecipe CreateShowRecipeView()
        {
            var newFrm = new frmShowRecipeView();
            return newFrm;
        }

        public IViewRecipesView CreateViewRecipeView()
        {
            var newFrm = new frmViewRecipes();
            return newFrm;
        }

        public IViewMenusView CreateViewMenusView()
        {
            var newFrom = new frmViewMenus();
            return newFrom;
        }

        public IAddNewMenuView CreateNewMenuView(IMainFormController cont, List<Recipe> recipes)
        {
            var newForm = new frmAddMenu(cont, recipes);
            return newForm;
        }

        public IChooseForRecommendationView CreateSelectionWindow(List<string> types, IMainFormController cont, List<string> ingred)
        {
            var newForm = new frmChooseForRecommendation(types, cont, ingred);
            return newForm;
        }

        public IShowIngredientView CreateShowIngredientView()
        {
            var newFrm = new frmShowIngredient();
            return newFrm;
        }

        public IShowToMakeView CreateShowToMakeView()
        {
            var newForm = new frmToMakeView();
            return newForm;
        }
    }
}
