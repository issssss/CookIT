using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;

namespace CookIT.Model.Factories
{
    public class RecipeFactory
    {
        
        public static Recipe CreateRecipe(int inID, string inName, string recType, Dictionary<string, string> ingred, string recText, List<Ingredient> list,string grade)
        {
            Recipe recc = null;
            RecipeTypesList.RecipeTypesEnum type;
            switch(recType)
            {
                case "Sweet":
                    type = RecipeTypesList.RecipeTypesEnum.SWEET;
                    break;
                case "Sour":
                    type = RecipeTypesList.RecipeTypesEnum.SOUR;
                    break;
                case "Savory":
                    type = RecipeTypesList.RecipeTypesEnum.SAVORY;
                    break;
                case "Hot":
                    type = RecipeTypesList.RecipeTypesEnum.HOT;
                    break;
                case "Bitter":
                    type = RecipeTypesList.RecipeTypesEnum.BITTER;
                    break;
                default:
                    throw new ArgumentException();
                    break;
                    
            }
                

            recc = new Recipe(inID, inName, type, ingred, recText, grade, list);

            return recc;
        }
    }
}
