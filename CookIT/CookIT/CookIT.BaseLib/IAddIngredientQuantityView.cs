using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;

namespace CookIT.BaseLib
{
    public interface IAddIngredientQuantityView
    {
        void ShowModaless(IAddNewRecipeView view, List<string> ingredientNames, IMainFormController inMainController);
    }
}
