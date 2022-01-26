using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;
namespace CookIT.BaseLib
{
    public interface IShowMenuView
    {
        void ShowMenu(int ID, IMenuRepository menuRep, IMainFormController mainCont, IRecipeRepository recRep);
    }
}
