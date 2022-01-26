using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model;
using CookIT.Model.Factories;
using CookIT.Model.Repositories;
using CookIT.BaseLib;
using System.Diagnostics;


namespace CookIT.Controllers
{
    public class MenuController
    {
        public void AddNewMenu(IAddNewMenuView inForm, IMenuRepository repository)
        {
            if(inForm.ShowModalView() == true)
            {
                try
                {
                    string name = inForm.MenuName;
                    string entree = inForm.Entree;
                    string mainCourse = inForm.MainCourse;
                    string desert = inForm.Desert;
                    int ID = repository.getNewID();
                    Meni newMenu = MenuFactory.CreateMenu(ID, name, entree, mainCourse, desert);
                    repository.addMenu(newMenu);


                }
                catch(Exception e)
                {
                    //Messa
                }
            }
        }
        public void ShowMenus(IViewMenusView viewMenus, IMenuRepository rep, IMainFormController cont)
        {
            viewMenus.ShowMenus(cont, rep);
        }
        public void DeleteMenu(int ID, IMenuRepository rep)
        { 
            rep.deleteMenu(ID);
        }

    }
}
