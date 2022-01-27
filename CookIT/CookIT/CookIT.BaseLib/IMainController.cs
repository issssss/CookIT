using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CookIT.Model.Repositories;
using CookIT.Model;

namespace CookIT.BaseLib
{
	public interface IMainFormController
	{
		void AddRecipe();
		void EditRecipe(int ID, string txt, string grade);
		void ViewRecipes();
		void AddIngredient();

		void ShowRecipe(int ID);

		void DeleteRecipe(int ID);

		void GetIngredientQuant(IAddNewRecipeView view, List<string> ingredients);

		void GetQuanityForRecipe(IAddNewRecipeView view,Dictionary<string, string> values);

		void AddMenu();
		
		void DeleteMenu(int ID);

		void ShowIngredient(string name);

		float calculateSumOfCalories(int ID);

		List<Meni> GetAllMenus();
		List<Recipe> GetAllRecipes();
		List<Ingredient> GetAllIngredients();
		List<Recipe> GetToMakeList();

		void AddToMakeList(int ID);
		void RemoveFromToMakeList(int ID);




	}
}
