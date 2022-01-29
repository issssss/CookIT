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
using System.Windows.Forms;


namespace CookIT.Controllers
{
    public class MenuController:IMenuController
    {
        public void AddNewMenu(IAddNewMenuView inForm, IMenuRepository repository, IRecipeRepository recRepository)
        {
            if(inForm.ShowModalView() == true)
            {
                try
                {
                    string name = inForm.MenuName;
                    if (name == "") throw new ArgumentNullException();
                    string entree = inForm.Entree;
                    string mainCourse = inForm.MainCourse;
                    string desert = inForm.Desert;
                    int ID = repository.getNewID();
                    List<Recipe> listOfCourses = new List<Recipe>();
                    listOfCourses.Add(recRepository.getRecipeByName(entree));
                    listOfCourses.Add(recRepository.getRecipeByName(mainCourse));
                    listOfCourses.Add(recRepository.getRecipeByName(desert));
                    Meni newMenu = MenuFactory.CreateMenu(ID, name, listOfCourses);
                    repository.addMenu(newMenu);


                }
                catch(Exception e)
                {
                    if(e is MenuAlreadyExists)
                        MessageBox.Show("The name of the menu is already taken.");
                    if(e is ArgumentNullException)
                        MessageBox.Show("Please choose a name of the menu.");
                    AddNewMenu(inForm, repository, recRepository);
                    return;
                }
            }
        }
        public void ShowMenus(IViewMenusView viewMenus, IMenuRepository rep, IMainFormController cont)
        {
            viewMenus.ShowMenus(cont, rep.GetAllMenus());
        }
        public void DeleteMenu(int ID, IMenuRepository rep)
        { 
            rep.deleteMenu(ID);
        }

    }
}
