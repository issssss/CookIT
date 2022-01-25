using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model;
using CookIT.Model.Repositories;

namespace CookIT.BaseLib
{
    public interface IViewRecipesView : IObserver
    {
        void ShowModaless(IMainFormController inMainController, IRecipeRepository rep);
    }
}
