using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CookIT.Model.Factories
{
    public class MenuFactory
    {
        public static Meni CreateMenu(int ID, string name, string ent, string mainCor, string des)
        {
            Meni menu = null;
            menu = new Meni(ID, name, ent, mainCor, des);
            return menu;

        }
    }
}
