using System;
using CookIT.BaseLib;
using CookIT.Model;
using CookIT.Model.Repositories;
using System.Collections.Generic;
using System.Diagnostics;
using CookIT.Model;

namespace CookIT.Controllers
{
	public class MainFormController : IMainFormController
	{
		private bool _defaultModelLoaded = false;

		private readonly IWindowFormsFactory	_formsFactory = null;
		private readonly IRecipeRepository _recipeRepository = null;																	
		private readonly IIngredientRepository _ingredientRepository = null;																	
		private readonly IMenuRepository _menuRepository = null;																	


		public MainFormController(IWindowFormsFactory inFormFactory, IRecipeRepository inRecipeRepo, IIngredientRepository inIngRepo, IMenuRepository menuRep)
		{
			_formsFactory = inFormFactory;
			_recipeRepository = inRecipeRepo;
			_ingredientRepository = inIngRepo;
			_menuRepository = menuRep;
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
				List<Ingredient> ingredients = _ingredientRepository.GetAllIngredients();
				_recipeRepository.addRecipe(new Recipe(1, "Medenjaci", (RecipeTypesList.RecipeTypesEnum) 1, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!","", ingredients));
				_recipeRepository.addRecipe(new Recipe(2, "Pizza Genovese", (RecipeTypesList.RecipeTypesEnum) 2, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!","",ingredients));
				_recipeRepository.addRecipe(new Recipe(3, "Wok s piletinom", (RecipeTypesList.RecipeTypesEnum) 3, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!","",ingredients));
				_recipeRepository.addRecipe(new Recipe(4, "Pire krumpir", (RecipeTypesList.RecipeTypesEnum) 5, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!","",ingredients));
				_recipeRepository.addRecipe(new Recipe(5, "Frigane lignje", (RecipeTypesList.RecipeTypesEnum) 4, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!","",ingredients));
				_recipeRepository.addRecipe(new Recipe(6, "Pohana piletina", (RecipeTypesList.RecipeTypesEnum)4, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", "",ingredients));
				_recipeRepository.addRecipe(new Recipe(7, "Gravce na tavce", (RecipeTypesList.RecipeTypesEnum) 3, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", "", ingredients));
				_recipeRepository.addRecipe(new Recipe(8, "Kiseli kupus", (RecipeTypesList.RecipeTypesEnum) 2, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", "",ingredients));
				_recipeRepository.addRecipe(new Recipe(9, "Spagetti Bolognese", (RecipeTypesList.RecipeTypesEnum) 4, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", "",ingredients));
				_recipeRepository.addRecipe(new Recipe(10, "Jaje na oko", (RecipeTypesList.RecipeTypesEnum) 5, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", "",ingredients));
				_recipeRepository.addRecipe(new Recipe(11, "Raspucanci", (RecipeTypesList.RecipeTypesEnum) 1, indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa.\n Zatim dodati jaja i promijesati. Sa strane spojiti suhe sastojke.\n Polagano umjesiti suhe sastojke s mokrima.\n Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice.\n Peci na 200 stupnjeva, 15 do 20 minuta.\n Bon Apetit!", "",ingredients));
				List<Recipe> forMeniRecipes = new List<Recipe>();
				List<Recipe> allRecipes = _recipeRepository.GetAllRecipes();
				forMeniRecipes.AddRange(allRecipes);
				_menuRepository.addMenu(new Meni(1, "Fina kombinacija", forMeniRecipes));
				_defaultModelLoaded = true;
			}
		}

	

        public void AddRecipe()
        {
			//throw new NotImplementedException();

			var recipeController = new RecipeController();

			var newFrm = _formsFactory.CreateAddNewRecipeView(RecipeTypesList.getRecipeTypesList(), this);

			recipeController.AddNewRecipe(newFrm, _recipeRepository, _ingredientRepository);
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
			recController.ShowRecipe(ID, newFrm, _recipeRepository, this);
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
			recController.GetIngredientQuant(view,newFrm, ingredients, this);
        }

        public void GetQuanityForRecipe(IAddNewRecipeView view, Dictionary<string, string> values)
        {
			var recController = new RecipeController();
			
			//var newFrm = _formsFactory.CreateAddNewRecipeView(RecipeTypesList.getRecipeTypesList(), this, _ingredientRepository);
			recController.GetQuantityforRecipe(view, values);
        }

        public void AddMenu()
        {
			
			var menuController = new MenuController();
			var newFrm = _formsFactory.CreateNewMenuView(this, _recipeRepository.GetAllRecipes());
			menuController.AddNewMenu(newFrm, _menuRepository, _recipeRepository);
			
			
		}

      
        public void DeleteMenu(int ID)
        {
			var menuCont = new MenuController();
			menuCont.DeleteMenu(ID, _menuRepository);
        }

        
		public void ViewMenus()
		{
			var menController = new MenuController();
			var newFrm = _formsFactory.CreateViewMenusView();
			menController.ShowMenus(newFrm,_menuRepository, this);
		}

		public void RecommendationWindow()
        {
			var cont = new RecipeController();
			var newFrm = _formsFactory.CreateSelectionWindow(RecipeTypesList.getRecipeTypesList(), this, _ingredientRepository.GetAllIngredientNames());
			var recipeFrm = _formsFactory.CreateShowRecipeView();
			cont.GetRecipeRecommentadion(newFrm, _recipeRepository, recipeFrm, this);
        }

        public void ShowIngredient(string name)
        {
			var cont = new IngredientController();
			var newFrm = _formsFactory.CreateShowIngredientView();
			cont.ShowIngredient(newFrm, name, _ingredientRepository);
        }

		public void ShowToMakeRecipe()
        {
			var recController = new RecipeController();
			var newForm = _formsFactory.CreateShowToMakeView();
			recController.ShowToMakeList(newForm, _recipeRepository, this);
        }

        public List<Meni> GetAllMenus()
        {
			return _menuRepository.GetAllMenus();
        }

        public List<Recipe> GetAllRecipes()
        {
			return _recipeRepository.GetAllRecipes();
        }

        public List<Ingredient> GetAllIngredients()
        {
			return _ingredientRepository.GetAllIngredients();
        }

        public List<Recipe> GetToMakeList()
        {
			return _recipeRepository.getAllToMakeRecipes();
        }

        public float calculateSumOfCalories(int ID)
        {
			return _recipeRepository.calculateSumOfCalories(ID);
        }

		public void AddToMakeList(int ID)
        {
			var controller = new RecipeController();
			controller.AddRecipeToMakeList(ID, _recipeRepository);
        }

		public void RemoveFromToMakeList(int ID)
        {
			var controller = new RecipeController();
			controller.RemoveFromToMakeList(ID, _recipeRepository);
        }
    }
}

