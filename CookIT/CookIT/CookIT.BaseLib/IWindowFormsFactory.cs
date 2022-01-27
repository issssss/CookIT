using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;
using CookIT.Model;

namespace CookIT.BaseLib
{
	public interface IWindowFormsFactory
	{

		IAddNewRecipeView CreateAddNewRecipeView(List<string> inRecipeType, IMainFormController cont);
		IViewRecipesView CreateViewRecipeView();
		IAddNewIngredientView CreateAddIngredientView();
		IShowRecipe CreateShowRecipeView();
		IAddIngredientQuantityView CreateIngredientsQuantityView();
		IViewMenusView CreateViewMenusView();
		IAddNewMenuView CreateNewMenuView(IMainFormController cont, List<Recipe> recipes);
		IShowIngredientView CreateShowIngredientView();
		IChooseForRecommendationView CreateSelectionWindow(List<string> types, IMainFormController cont, List<string> ingrep);
		IShowToMakeView CreateShowToMakeView();
	}
}
