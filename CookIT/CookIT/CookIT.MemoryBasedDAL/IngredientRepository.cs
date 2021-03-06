using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model;
using CookIT.Model.Repositories;

namespace CookIT.MemoryBasedDAL
{
    public class IngredientRepository : IIngredientRepository
    {

        private static int _nextID = 1;
        private static IngredientRepository _instance;

        private readonly List<Ingredient> _listIngredients = new List<Ingredient>();

        public static IngredientRepository getInstance()
        {
            return _instance ?? (_instance = new IngredientRepository());
        }
        public void addIngredient(Ingredient addIng)
        {
            if(_listIngredients.Any(ing => ing.Name == addIng.Name))
            {
                throw new IngredientAlreadyExists();
            }

            while (addIng.Id == Ingredient.UndefinedIngredientID || _listIngredients.Any(ing => ing.Id == addIng.Id))
                addIng.Id = getNewId();
            Debug.WriteLine(addIng.Name);

            _listIngredients.Add(addIng);
        }

   

        public List<int> getAllIngredientIDs()
        {
            return _listIngredients.Select(ing => ing.Id).ToList();
        }

        public List<string> GetAllIngredientNames()
        {
            return _listIngredients.Select(ing => ing.Name).ToList();
        }

        public List<Ingredient> GetAllIngredients()
        {
            return _listIngredients;
        }

        public Ingredient getIngredientByID(int inIngID)
        {
            try
            {
                var ing = (from l in _listIngredients where l.Id == inIngID select l).First();
                return ing;
            }
            catch (Exception e)
            {
                throw new IngredientDoesntExist();
            }
        }

        public Ingredient getIngredientByName(string ingName)
        {
            try
            {
                var ing = (from l in _listIngredients where l.Name == ingName select l).First();
                return ing;
            }
            catch (Exception e)
            {
                throw new IngredientDoesntExist();
            } 
           
        }

        public int getNewId()
        {
            int nextID = _nextID;
            _nextID++;

            return nextID;
        }

   
    }
}
