using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CookIT.Model.Factories
{
    public class MenuFactory
    {
        public static Meni CreateMenu(int ID, string name, List<Recipe> chosenCourses)
        {
            Meni menu = null;
            menu = new Meni(ID, name, chosenCourses);
            return menu;

        }
    }
}
