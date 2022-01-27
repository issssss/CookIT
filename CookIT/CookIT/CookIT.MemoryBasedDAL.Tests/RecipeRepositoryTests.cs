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
    public class RecipeRepositoryTests
    {
        [TestInitialize]
        public void ReInitializeRecipeRepository()
        {
            System.Reflection.FieldInfo f1 = typeof(RecipeRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(f1);
            f1.SetValue(null, null);

            System.Reflection.FieldInfo f2 = typeof(IngredientRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(f2);
            f2.SetValue(null, null);

        }

        [TestMethod]
        [ExpectedException(typeof(RecipeAlreadyExists))]
        public void DoesRecipeWithNameAlreadyExistTest()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe);
            Recipe newRecipe2 = RecipeFactory.CreateRecipe(5, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe2);


        }

        [TestMethod]
        public void CreatingThreeRecipesTest()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe1 = RecipeFactory.CreateRecipe(1, "Riza s povrcem", "ljuto", indIngred, "Puno paprike", "");
            Recipe newRecipe2 = RecipeFactory.CreateRecipe(2, "Cokoladna torta", "Sweet", indIngred, "Slag na vrhu", "");
            Recipe newRecipe3 = RecipeFactory.CreateRecipe(3, "Espresso", "gorko", indIngred, "Nije za slabe ljude", "");
            recRep.addRecipe(newRecipe1);
            recRep.addRecipe(newRecipe2);
            recRep.addRecipe(newRecipe3);
            int quan = recRep.GetAllRecipes().Count;
            Assert.AreEqual(3, quan);

        }

        [TestMethod]
        [ExpectedException(typeof(RecipeAlreadyExists))]
        public void AddingTwoSameRecipesTest()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino","");
            recRep.addRecipe(newRecipe);
            recRep.addRecipe(newRecipe);


        }

        [TestMethod]
        [ExpectedException(typeof(RecipeDoesntExist))]
        public void FindNoneExistingRecipeByName()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe);

            Recipe recipe2 = recRep.getRecipeByName("Biti ili ne biti.");
        }

        [TestMethod]
        public void GetRecipeByID()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe);
            Recipe recipe = recRep.getRecipeByID(1);
            Assert.AreEqual(newRecipe, recipe);
        }
        [TestMethod]
        public void EditRecipeTest()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe);
            recRep.editRecipe(1, "Jos finije", "8");
            Assert.AreEqual(1, recRep.GetAllRecipes().Count);
            Assert.AreNotEqual("Fino", recRep.getRecipeByID(1).Text);
        }

        [TestMethod]
        public void DeleteRecipeTest()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe);
            recRep.deleteRecipe(1);
            Assert.AreEqual(0, recRep.GetAllRecipes().Count);
            
        }
        [TestMethod]
        public void RemoveRecipeFromToMakeTest()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" }, { "Glatko brašno", "2 cups" }, { "Jaja", "4" }, { "Cimet", "2 tbsp" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe);
            recRep.addToMakeRecipe(newRecipe.Id);
            recRep.removeToMakeRecipe(1);
            Assert.AreEqual(0, recRep.getAllToMakeRecipes().Count);

        }
        [TestMethod]
        public void CheckCaloriesTest()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            IngredientRepository ingrep = IngredientRepository.getInstance();
            ingrep.addIngredient(new Ingredient(1, "Voda", 0, 0, 0, 0, 0, 0, 0));
            ingrep.addIngredient(new Ingredient(2, "Glatko brašno", 350, 12, 73, 2, 7, (float)0.12, (float)0.1));
            ingrep.addIngredient(new Ingredient(3, "Med", 304, 1, 82, 0, 1, 0, 5));
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe);
            float sum = recRep.calculateSumOfCalories(1);
            Assert.AreEqual(152, sum);

        }
        [TestMethod]
        public void CheckRecommendationTest()
        {
            RecipeRepository recRep = RecipeRepository.getInstance();
            IngredientRepository ingrep = IngredientRepository.getInstance();
            ingrep.addIngredient(new Ingredient(1, "Voda", 0, 0, 0, 0, 0, 0, 0));
            ingrep.addIngredient(new Ingredient(2, "Glatko brašno", 350, 12, 73, 2, 7, (float)0.12, (float)0.1));
            ingrep.addIngredient(new Ingredient(3, "Med", 304, 1, 82, 0, 1, 0, 5));
            Dictionary<string, string> indIngred = new Dictionary<string, string>() { { "Voda", "4 cups" }, { "Med", "5 tbs" } };
            Recipe newRecipe = RecipeFactory.CreateRecipe(1, "Medenjaci", "Sweet", indIngred, "Fino", "");
            recRep.addRecipe(newRecipe);
            int ID = recRep.getRecommendation("Sour", "");
            Assert.AreEqual(-1, ID);
            int ID2 = recRep.getRecommendation("Sweet", "Med");
            Assert.AreEqual(1, ID2);
            int ID3 = recRep.getRecommendation("", "Glatko brašno");
            Assert.AreEqual(-1, ID3);
        }
    }
}
