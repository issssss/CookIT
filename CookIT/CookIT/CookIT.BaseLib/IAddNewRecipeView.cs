using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.BaseLib
{
    public interface IAddNewRecipeView
    {
        bool ShowModalView();

        string RecipeName { get; }
        string RecipeType { get; }
        Dictionary<string, string> RecipeIngred { get; }
        string RecipeText { get; }

        void SaveQuantity(Dictionary<string, string> values);
    }
}
