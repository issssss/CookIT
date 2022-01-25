using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;

namespace CookIT.BaseLib
{
	public interface IWindowFormsFactory
	{

		IAddNewRecipeView CreateAddNewRecipeView(List<string> inRecipeType, IMainFormController cont, IIngredientRepository rep);
		IViewRecipesView CreateViewRecipeView();
		IAddNewIngredientView CreateAddIngredientView();
		IShowRecipe CreateShowRecipeView();
		IAddIngredientQuantityView CreateIngredientsQuantityView();

	}
}
