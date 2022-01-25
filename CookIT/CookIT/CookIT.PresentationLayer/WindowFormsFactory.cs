using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.BaseLib;
using CookIT.Model.Repositories;

namespace CookIT.PresentationLayer
{
	public class WindowFormsFactory : IWindowFormsFactory
	{

        public IAddNewIngredientView CreateAddIngredientView()
        {
            
            var newFrm = new frmAddIngredient();
            return newFrm;
        }

        public IAddNewRecipeView CreateAddNewRecipeView(List<string> inRecipeType, IMainFormController cont, IIngredientRepository rep)
        {
			var newFrm = new frmAddRecipe(inRecipeType, cont, rep);
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
    }
}
