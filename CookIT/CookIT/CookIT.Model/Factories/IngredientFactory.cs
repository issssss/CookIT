using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model.Factories
{
    public class IngredientFactory
    {
        //(int inID, string inName, int energy, int carbs, int proteins, int fats, int fibs, float salt, float minerals)
        public static Ingredient CreateIngredient(int inID, string name, int energy, int carbs, int proteins, int fats, int fibs, float salt, float minerals)
        {
            Ingredient ingred = null;
            ingred = new Ingredient(inID, name, energy, carbs, proteins, fats, fibs, salt, minerals);

            return ingred;
        }
    }
}
