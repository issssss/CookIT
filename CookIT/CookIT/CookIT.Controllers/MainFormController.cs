using System;
using CookIT.BaseLib;
using CookIT.Model;
using CookIT.Model.Repositories;
using System.Collections.Generic;
using System.Diagnostics;

namespace CookIT.Controllers
{
	public class MainFormController : IMainFormController
	{
		private bool _defaultModelLoaded = false;

		private readonly IWindowFormsFactory	_formsFactory = null;
		private readonly IRecipeRepository _recipeRepository = null;																	
		private readonly IIngredientRepository _ingredientRepository = null;																	


		public MainFormController(IWindowFormsFactory inFormFactory, IRecipeRepository inRecipeRepo, IIngredientRepository inIngRepo)
		{
			_formsFactory = inFormFactory;
			_recipeRepository = inRecipeRepo;
			_ingredientRepository = inIngRepo;
			LoadDefaultModel();
			
		}
		public void LoadDefaultModel()
		{
			if (_defaultModelLoaded == false)
			{
				_ingredientRepository.addIngredient(new Ingredient(1, "Voda", 0, 0, 0, 0, 0, 0, 0));
				_ingredientRepository.addIngredient(new Ingredient(2, "Glatko brašno", 350, 12, 73, 2, 7, (float)0.12, (float)0.1));
				_ingredientRepository.addIngredient(new Ingredient(3, "Med", 304, 1, 82, 0, 1, 0, 5));
				_ingredientRepository.addIngredient(new Ingredient(4, "Jaja", 49, 1, 11, 1, 1, 1, 2));
				_ingredientRepository.addIngredient(new Ingredient(5, "Cimet", 247, 81, 4, 1, 4, 1, 0));
				Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
				_recipeRepository.addRecipe(new Recipe(1, "Medenjaci", "Slatko", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!",""));
				_recipeRepository.addRecipe(new Recipe(2, "Pizza Genovese", "Slano", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!",""));
				_recipeRepository.addRecipe(new Recipe(3, "Wok s piletinom", "Ljuto", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!",""));
				_recipeRepository.addRecipe(new Recipe(4, "Pire krumpir", "Slano", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!",""));
				_recipeRepository.addRecipe(new Recipe(5, "Frigane lignje", "Slano", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!",""));
				_recipeRepository.addRecipe(new Recipe(6, "Pohana piletina", "Slano", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", ""));
				_recipeRepository.addRecipe(new Recipe(7, "Gravce na tavce", "Ljuto", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", ""));
				_recipeRepository.addRecipe(new Recipe(8, "Kiseli kupus", "Kiselo", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", ""));
				_recipeRepository.addRecipe(new Recipe(9, "Spagetti Bolognese", "Slano", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", ""));
				_recipeRepository.addRecipe(new Recipe(10, "Jaje na oko", "Gorko", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", ""));
				_recipeRepository.addRecipe(new Recipe(11, "Raspucanci", "Slatko", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", ""));

				_defaultModelLoaded = true;
			}
		}

	

        public void AddRecipe()
        {
			//throw new NotImplementedException();

			var recipeController = new RecipeController();

			var newFrm = _formsFactory.CreateAddNewRecipeView(RecipeTypesList.getRecipeTypesList(), this, _ingredientRepository);

			recipeController.AddNewRecipe(newFrm, _recipeRepository);
        }

        public void EditRecipe(int ID, string text, string grade)
        {
			var repController = new RecipeController();
			repController.EditRecipe(ID, text, grade, _recipeRepository);
        }

        public void ViewRecipes()
        {
			var recController = new RecipeController();
			var newFrm = _formsFactory.CreateViewRecipeView();
			recController.ShowRecipes(newFrm, _recipeRepository, this);
        }

		public void AddIngredient()
        {
			var ingController = new IngredientController();
			var newFrm = _formsFactory.CreateAddIngredientView();
			ingController.AddNewIngredient(newFrm, _ingredientRepository);
        }

        public void ShowRecipe(int ID)
        {
			var recController = new RecipeController();
			var newFrm = _formsFactory.CreateShowRecipeView();
			recController.ShowRecipe(ID, newFrm, _recipeRepository, _ingredientRepository, this);
        }

        public void DeleteRecipe(int ID)
        {
			var recController = new RecipeController();
			recController.DeleteRecipe(ID, _recipeRepository);
        }

        public void GetIngredientQuant(IAddNewRecipeView view,List<string> ingredients)
        {
			var recController = new RecipeController();
			var newFrm = _formsFactory.CreateIngredientsQuantityView();
			recController.GetIngredientQuant(view,newFrm, ingredients, this, _ingredientRepository);
        }

        public void GetQuanityForRecipe(IAddNewRecipeView view, Dictionary<string, string> values)
        {
			var recController = new RecipeController();
			
			//var newFrm = _formsFactory.CreateAddNewRecipeView(RecipeTypesList.getRecipeTypesList(), this, _ingredientRepository);
			recController.GetQuantityforRecipe(view, values);
        }
    }
}
