using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookIT.Model;
using CookIT.Model.Factories;

namespace CookIT.MemoryBasedDAL.Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestInitialize]
        public void ReInitializeMenuRepository()
        {
            System.Reflection.FieldInfo f1 = typeof(MenuRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(f1);
            f1.SetValue(null, null);

            System.Reflection.FieldInfo f2 = typeof(IngredientRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(f2);
            f2.SetValue(null, null);

            System.Reflection.FieldInfo f3 = typeof(RecipeRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(f3);
            f3.SetValue(null, null);

        }

        [TestMethod]
        [ExpectedException(typeof(MenuAlreadyExists))]
        public void DoesMenuWithNameAlreadyExistTest()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            List<Recipe> recipes = DataForTesting();
            Meni newMenu = MenuFactory.CreateMenu(1, "Fini Meni", recipes);
            recRep.addMenu(newMenu);
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Fini Meni", recipes);
            recRep.addMenu(newMenu2);


        }

        [TestMethod]
        public void CreatingThreeMenusTest()
        {
            MenuRepository recRep = MenuRepository.getInstance();
   
            List<Recipe> recipes = DataForTesting();

            Meni newMenu = MenuFactory.CreateMenu(1, "Fini Meni", recipes);
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Jos bolji meni", recipes);
            Meni newMenu3 = MenuFactory.CreateMenu(3, "njah meni", recipes);
            recRep.addMenu(newMenu);
            recRep.addMenu(newMenu2);
            recRep.addMenu(newMenu3);
            int quan = recRep.GetAllMenus().Count;
            Assert.AreEqual(3, quan);

        }

        [TestMethod]
        [ExpectedException(typeof(MenuAlreadyExists))]
        public void AddingTwoSameMenusTest()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            List<Recipe> recipes = DataForTesting();
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Jos bolji meni", recipes);
            recRep.addMenu(newMenu2);
            recRep.addMenu(newMenu2);


        }

        [TestMethod]
        [ExpectedException(typeof(MenuDoesntExist))]
        public void FindNoneExistingMenuByName()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            List<Recipe> recipes = DataForTesting();
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Jos bolji meni", recipes);
            recRep.addMenu(newMenu2);

            Meni recipe2 = recRep.getMenuByName("Biti ili ne biti.");
        }

        [TestMethod]
        public void GetMenuByID()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            List<Recipe> recipes = DataForTesting();
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Jos bolji meni",recipes);
            recRep.addMenu(newMenu2);
            Meni menu = recRep.getMenuByID(2);
            Assert.AreEqual(newMenu2, menu);
        }
       

        [TestMethod]
        public void DeleteMenuTest()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            List<Recipe> recipes = DataForTesting();
            Meni newMenu2 = MenuFactory.CreateMenu(1, "Jos bolji meni", recipes);
            recRep.addMenu(newMenu2);
            recRep.deleteMenu(1);
            Assert.AreEqual(0, recRep.GetAllMenus().Count);

        }

        private List<Recipe> DataForTesting()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            IngredientRepository ingrep = IngredientRepository.getInstance();
            ingrep.addIngredient(new Ingredient(1, "Voda", 0, 0, 0, 0, 0, 0, 0));
            ingrep.addIngredient(new Ingredient(2, "Glatko brašno", 350, 12, 73, 2, 7, (float)0.12, (float)0.1));
            ingrep.addIngredient(new Ingredient(3, "Med", 304, 1, 82, 0, 1, 0, 5));
            List<Ingredient> ingredients = ingrep.GetAllIngredients();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe1 = RecipeFactory.CreateRecipe(1, "Riza s povrcem", "Hot", indIngred, "Puno paprike", ingredients, "");
            Recipe newRecipe2 = RecipeFactory.CreateRecipe(2, "Cokoladna torta", "Sweet", indIngred, "Slag na vrhu", ingredients, "");
            Recipe newRecipe3 = RecipeFactory.CreateRecipe(3, "Espresso", "Bitter", indIngred, "Nije za slabe ljude", ingredients, "");
            recRep.addRecipe(newRecipe1);
            recRep.addRecipe(newRecipe2);
            recRep.addRecipe(newRecipe3);
            return recRep.GetAllRecipes();
        }
    }
}

