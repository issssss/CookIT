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
        List<int> RecipeIngred { get; }
        string RecipeText { get; }
    }
}
