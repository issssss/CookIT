using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model
{
    public static class RecipeTypesList
    {
        public enum RecipeTypesEnum: int
        {
            SWEET = 1,
            SAVORY = 2,
            SOUR = 3,
            HOT = 4,
            BITTER = 5
        };

        public static Dictionary<RecipeTypesEnum, string> RecTypeDict = new Dictionary<RecipeTypesEnum, string>
        {
            {RecipeTypesEnum.SWEET, "Sweet" },
            {RecipeTypesEnum.SOUR, "Sour" },
            {RecipeTypesEnum.SAVORY, "Savory" },
            {RecipeTypesEnum.HOT, "Hot" },
            {RecipeTypesEnum.BITTER, "Bitter" }
        };

        public static List<string> getRecipeTypesList()
        {
            return RecTypeDict.Select(x => x.Value).ToList();
        }

    }
}
