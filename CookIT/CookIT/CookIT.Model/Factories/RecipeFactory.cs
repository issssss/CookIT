using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model.Factories
{
    public class RecipeFactory
    {
        public static Recipe CreateRecipe(int inID, string inName, string recType, List<int> ingred, string recText)
        {
            Recipe recc = null;
            recc = new Recipe(inID, inName, recType, ingred, recText);

            return recc;
        }
    }
}
