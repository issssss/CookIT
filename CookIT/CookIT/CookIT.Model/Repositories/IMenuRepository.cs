using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model.Repositories
{
    public interface IMenuRepository
    {
        int getNewID();
        Meni getMenuByID(int ID);
        Meni getMenuByName(string menuName);

        List<int> getAllMenuIDs();
        List<String> GetAllMenuNames();
        List<Meni> GetAllMenus();
        void addMenu(Meni addMenu);

        void deleteMenu(int menuID);
    }
}