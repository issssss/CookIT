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
    public class IngredientRepositoryTests
    {

        [TestInitialize]
        public void ReInitializeIngredientRepository()
        {
            System.Reflection.FieldInfo f1 = typeof(IngredientRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(f1);
            f1.SetValue(null, null);

        }

        [TestMethod]
        [ExpectedException(typeof(IngredientAlreadyExists))]
        public void DoesIngredientWithNameAlreadyExistTest()
        {
            IngredientRepository ingRep = IngredientRepository.getInstance();
            
            Ingredient newIngredient = IngredientFactory.CreateIngredient(1, "Voda", 0, 0, 0, 0, 0, 0, 0);
            ingRep.addIngredient(newIngredient);
            Ingredient newIngredient2 = IngredientFactory.CreateIngredient(2, "Voda", 0, 0, 0, 0, 0, 0, 0);
            ingRep.addIngredient(newIngredient2);


        }

        [TestMethod]
        public void CreatingThreeIngredientsTest()
        {
            IngredientRepository ingRep = IngredientRepository.getInstance();

            Ingredient newIngredient1 = IngredientFactory.CreateIngredient(1, "Voda", 0, 0, 0, 0, 0, 0, 0);
            Ingredient newIngredient2 = IngredientFactory.CreateIngredient(2, "Naranca", 76, 15, 4, (float)0.2, 0, 10, 4);
            Ingredient newIngredient3 = IngredientFactory.CreateIngredient(3, "Mrkva", 45, 4, (float)7.7, 5, 8, 9, 0);
            
            ingRep.addIngredient(newIngredient1);
            ingRep.addIngredient(newIngredient2);
            ingRep.addIngredient(newIngredient3);
            int quan = ingRep.GetAllIngredients().Count;
            Assert.AreEqual(3, quan);

        }

        [TestMethod]
        [ExpectedException(typeof(IngredientAlreadyExists))]
        public void AddingTwoSameIngredientsTest()
        {
            IngredientRepository ingRep = IngredientRepository.getInstance();

            Ingredient newIngredient = IngredientFactory.CreateIngredient(2, "Naranca", 76, 15, 4, (float)0.2, 0, 10, 4);
            ingRep.addIngredient(newIngredient);
            ingRep.addIngredient(newIngredient);


        }

        [TestMethod]
        [ExpectedException(typeof(IngredientDoesntExist))]
        public void FindNoneExistingIngredientByName()
        {
            IngredientRepository ingRep = IngredientRepository.getInstance();

            Ingredient newIngredient = IngredientFactory.CreateIngredient(2, "Naranca", 76, 15, 4, (float)0.2, 0, 10, 4);
            ingRep.addIngredient(newIngredient);

            Ingredient ingredient2 = ingRep.getIngredientByName("Biti ili ne biti.");
        }

        [TestMethod]
        public void GetIngredientByID()
        {
            IngredientRepository ingRep = IngredientRepository.getInstance();

            Ingredient newIngredient = IngredientFactory.CreateIngredient(2, "Naranca", 76, 15, 4, (float)0.2, 0, 10, 4);
            ingRep.addIngredient(newIngredient);
            Ingredient ingredient = ingRep.getIngredientByID(2);
            Assert.AreEqual(newIngredient, ingredient);
        }
        [TestMethod]
        public void AdjustIDTest()
        {
            IngredientRepository ingRep = IngredientRepository.getInstance();

            Ingredient newIngredient = IngredientFactory.CreateIngredient(1, "Naranca", 76, 15, 4, (float)0.2, 0, 10, 4);
            ingRep.addIngredient(newIngredient);
            Ingredient newIngredient1 = IngredientFactory.CreateIngredient(1, "Voda", 0, 0, 0, 0, 0, 0, 0);
            ingRep.addIngredient(newIngredient1);
            Assert.AreEqual(2, ingRep.getIngredientByName("Voda").Id);
        }

      
    }
}
