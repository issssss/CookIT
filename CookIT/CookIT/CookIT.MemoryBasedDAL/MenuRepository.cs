using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;
using CookIT.Model;
using CookIT.Model.Factories;

namespace CookIT.MemoryBasedDAL
{
    public class MenuRepository : IMenuRepository
    {
        private static int _nextID = 1;
        private static MenuRepository _instance;
        private readonly List<Meni> _menuList = new List<Meni>();

        public static MenuRepository getInstance()
        {
            return _instance ?? (_instance = new MenuRepository());
        }
        public void addMenu(Meni addMenu)
        {
            if (_menuList.Any(menu => menu.Name == addMenu.Name))
            {
                throw new MenuAlreadyExists();
            }
            while (addMenu.Id == Meni.UndefinedMenuId || _menuList.Any(menu => menu.Id == addMenu.Id))
            {
                addMenu.Id = getNewID();
            }
            _menuList.Add(addMenu);
        }

        public void deleteMenu(int menuID)
        {
            Meni toRemove = this.getMenuByID(menuID);
            this._menuList.Remove(toRemove);
        }

        public List<int> getAllMenuIDs()
        {
            return _menuList.Select(menu => menu.Id).ToList();
        }

        public List<string> GetAllMenuNames()
        {
            return _menuList.Select(menu => menu.Name).ToList();
        }

        public List<Meni> GetAllMenus()
        {
            return _menuList;
        }

        public Meni getMenuByID(int ID)
        {
            try
            {
                var menu = (from l in _menuList where l.Id == ID select l).First();
                return menu;
            }
            catch (Exception e)
            {
                throw new MenuDoesntExist();
            }
        }

        public Meni getMenuByName(string menuName)
        {
            try
            {
                var menu = (from l in _menuList where l.Name == menuName select l).First();
                return menu;
            }
            catch (Exception e)
            {
                throw new MenuDoesntExist();
            }
        }

        public int getNewID()
        {
            int nextID = _nextID;
            _nextID++;
            return nextID;
        }

    }
}
