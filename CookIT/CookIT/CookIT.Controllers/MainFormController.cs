using System;
using CookIT.BaseLib;
using CookIT.Model;
using CookIT.Model.Repositories;
using System.Collections.Generic;
using System.Diagnostics;
using CookIT.Model.Factories;

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
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(1, "Water", 0, 0, 0, 0, 0, 0, 0));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(2, "Flour", 350, 12, 73, 2, 7, (float)0.12, (float)0.1));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(3, "Honey", 304, 1, 82, 0, 1, 0, 5));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(4, "Egg", 49, 1, 11, 1, 1, 1, 2));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(5, "Cinnamon", 247, 81, 4, 1, 4, 1, 0));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(6, "Sugar", 290, 81, 4, 1, 4, 1, 0));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(7, "Butter", 716, (float)0.1, (float)0.9, 81, 0, (float)0.1, 0));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(8, "Chocolate", 545, (float)61, (float)4.9, 31, 0, (float)0.07, 0));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(9, "Cabbage", 24, (float) 6, (float)1.3, (float)0.1, (float)2.5, (float)0.02, (float) 0.05));
				_ingredientRepository.addIngredient(IngredientFactory.CreateIngredient(10, "Chicken", 165, (float) 0, (float)37, (float)4.3, (float)2.5, (float)0, (float) 0.09));
				Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Butter", "250g" }, { "Honey", "5 tbs" }, { "Flour", "800g" }, { "Egg", "4" }, { "Cinnamon", "2 tbsp" }, { "Sugar", "200g" } };
				Dictionary<string, string> indIngred1 = new Dictionary<string, string>() { { "Butter", "250g" }, { "Honey", "5 tbs" }, { "Flour", "800g" }, { "Egg", "4" }, };
				Dictionary<string, string> indIngred2 = new Dictionary<string, string>() { { "Butter", "250g" }, { "Flour", "800g" }, { "Egg", "4" }, };
				Dictionary<string, string> indIngred3 = new Dictionary<string, string>() { { "Butter", "50g" }, { "Flour", "200g" }, { "Egg", "2" }, { "Sugar", "200g" }, { "Chocolate", "200g" } };
				Dictionary<string, string> indIngred4 = new Dictionary<string, string>() { { "Butter", "25g" },{ "Egg", "1" } };
				Dictionary<string, string> indIngred5 = new Dictionary<string, string>() { { "Cabbage", "5 wholes" } };
				Dictionary<string, string> indIngred6 = new Dictionary<string, string>() { { "Water", "Lonac" } };
				Dictionary<string, string> indIngred7 = new Dictionary<string, string>() { { "Chicken", "200g" },{ "Egg", "1" }, { "Flour", "50g" } };
				List<Ingredient> ingredients = _ingredientRepository.GetAllIngredients();
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Smijesati prvo med i maslac dok se ne dobije ujednacena smjesa. Zatim dodati jaja i promijesati." + Environment.NewLine +"Sa strane spojiti suhe sastojke. Polagano umjesiti suhe sastojke s mokrima. Ostaviti smjesu da odstoji sat vremena te zatim oblikovati kuglice. Peci na 200 stupnjeva, 15 do 20 minuta."+Environment.NewLine+"Bon Apetit!",ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(2, "Pizza Genovese", "Savory", indIngred1, "Napraviti jednostavno tijesto od vode, brašna, soli i kvasca. Mijesiti dok meso ne postane rastezljivo. Ostaviti tijesto da odstoji 2 sata."+ Environment.NewLine + "Razvaljati tijesto na željenu debljinu, ja volim malo deblje tako da oko 2cm. Staviti pasiranu rajčicu, šunku, sir i povrće. Peći na 200 stupnjeva, 20 minuta."+ Environment.NewLine + "Bon Apetit!", ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(3, "Wok s piletinom", "Hot", indIngred7, "Ne znam ovo napraviti, ali planiram naučiti",ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(4, "Frigane lignje", "Savory", indIngred4, "(Ovaj recept ne sadrži dobre namirnice, ali to nije greška samo manjak vremena:()" + Environment.NewLine + "Kupljene lignje očistiti, osušiti te narezati na kolutiće otprilike 1cm u širini. Zagrijati ulje te dok se grije, lignje uvaljati u oštro brašno." + Environment.NewLine + " Peći u ulju dok ne porumene. Izvaditi i staviti na papirnati ručnik da se upije višak ulja. Poslužiti uz voljen prilog, ja preporučam kuhani krumpir ili krumpir salatu." + Environment.NewLine + " Bon Apetit!", ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(5, "Krumpir salata", "Sour", indIngred6, "Oguliti i narezati krumpir na komade. Ubaciti u prethodno proključanu vodu i ostaviti da se kuha 20tak minuta. Krumpir je gotov kad se raspada prilikom ubadanja vilicom." + Environment.NewLine + " U međuvremenu oguliti i narezati luk na ploške. Kada se krumpir ocijedi, dodati luk, papar, sol, ulje i ocat te sve dobro promiješati. " + Environment.NewLine + "Bon Apetit!", ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(6, "Pohana piletina", "Savory", indIngred7, "Izrezati piletinu na odreske. Posoliti (ili povegetiti) piletinu i lagano ju istući. Istuči jaje s mlijekom i malo soli." + Environment.NewLine + "Redom stavljati piletinu u brašno, pa smjesu od jaja te na kraju u krušne mrvice (panko ili domaće sušene su najbolje). Takvu piletinu staviti u prethodno zagrijano ulje i peći dok kora ne pozlati. Staviti na kuhinjski papir da se ocijedi od viška ulja. " + Environment.NewLine + "Bon Apetit! ", ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(7, "Gravce na tavce", "Hot", indIngred6, "(Ovaj recept ne sadrži dobre namirnice, ali to nije greška samo manjak vremena:()" + Environment.NewLine + "Narezati luk na sitno te voljene suhomesnate proizvode (najbolja je slanina i kobasica). Zdinstati luk, dodati suhomesnate proizvode te onda već ranije napravljen grah. " + Environment.NewLine + "Dodati začine po volji, poput ljute paprike. Pustiti da se krčka nekih pola sata dok se sve ne ujedini. " + Environment.NewLine + "Bon Apetit!", ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(8, "Kiseli kupus", "Sour", indIngred5, "Kupiti (ili uzgojiti) lijepe glavice kupusa. Ukloniti prvi sloj listova. Izdubiti kupus u korijenu (otprilike da bude duboko do polovine kupusa). Udubinu popuniti solju. " + Environment.NewLine + "U kacu poslagati kupus te naliti vode da pokrije sve glavice u potpunosti. Posoliti dodatno vodu. Kupus stisnuti s teškim predmetom (drvenom daskom ili kamenom). " + Environment.NewLine + "Ostaviti na neko toplo mjesto i čekati mjesec do dva. Radi boje poželjno je ubaciti kukuruz tijekom čekanja. " + Environment.NewLine + "Bon apetit!", ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(9, "Spagetti Bolognese", "Hot", indIngred2, "Izrezati luk, mrkvu i češnjak na sitnu. Izrezati pancetu na komadiće. Zdinstati lik i mrkvu te kada su već popustili dodati češnjak. Zatim dodati pancetu i dinstati. " + Environment.NewLine + "Kada se komadići pancete smanje dodati mljeveno meso. Kada meso potamni u potpunosti dodati začine; sol, papar, vegetu, crvenu papriku, ljutu papriku i origano. Promiješati sve da bude ujednačeno. " + Environment.NewLine + "Dodati rajčice (pasirane) te malo crvenog vina. Pustiti da se kuha i po potrebi dodavati tople vode ili temeljca od govedine. " + Environment.NewLine + "Pustiti da se krčka nekih pola sata. U međuvremenu skuhati špagete i procijediti ih. Poslužiti uz parmezan. " + Environment.NewLine + "Bon apetit!", ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(10, "Jaje na oko", "Bitter", indIngred4, "Zagrijat tavu, dodati ulje i razbiti jaje na tavu. Posoliti po želji. Zašto je bitter? Jer ja volim dodati malo papra. Bon apetit!", ingredients, ""));
				_recipeRepository.addRecipe(RecipeFactory.CreateRecipe(11, "Raspucanci", "Sweet", indIngred3, "Čokoladu otopite na pari. Neka vam se malo ohladi. Jaja, šećer i vanilij šećer pjenasto izradite. Dodajte im maslac sobne temperature i otopljenu čokoladu. Sve povežite mikserom. " + Environment.NewLine + "U zasebnoj posudi pomiješajte brašno koje ste prethodno prosijali, prašak za pecivo i prstohvat soli. Polako dodajite smjesi jaja, šećera, maslaca i čokolade. Cijelo vrijeme miksajte na laganoj brzini. " + Environment.NewLine + "Kada sve sastojke povezali i dobili jednolično tijesto, pokrijte ga i spremite u hladnjak na dva sata. Pećnicu ugrijte na 180 stupnjeva. Pripremite dva lima za pečenje koja ste obložili papirom za pečenje." + Environment.NewLine + "U posudu stavite šećer u prahu(u njega ćete valjati kuglice) Tijesto vadite žličicom, neka vam bude veličine oraha. Rukama oblikujte kuglicu. Oblikovanu kuglicu uvaljajte u šećer u prahu. Uvaljanu kuglicu potom prebacite na lim za pečenje. Slažite ih pazeći da ostavite razmak između svake. Pecite ih 10 - ak minuta. Ohlađene keksiće spremite u kutiju za kekse i potrošte unutar 14 dana." + Environment.NewLine + "Bon Apetit!", ingredients, ""));
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

