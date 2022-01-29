using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;

namespace CookIT.BaseLib
{
    public interface IMenuController
    {
        void AddNewMenu(IAddNewMenuView inForm, IMenuRepository repository, IRecipeRepository recRepository);
        void ShowMenus(IViewMenusView viewMenus, IMenuRepository rep, IMainFormController cont);
        void DeleteMenu(int ID, IMenuRepository rep);
    }
}
