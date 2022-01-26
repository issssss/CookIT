using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookIT.Model;
using CookIT.Model.Factories;

namespace CookIT.MemoryBasedDAL.Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        [TestInitialize]
        public void ReInitializeMenuRepository()
        {
            System.Reflection.FieldInfo f1 = typeof(MenuRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(f1);
            f1.SetValue(null, null);

        }

        [TestMethod]
        [ExpectedException(typeof(MenuAlreadyExists))]
        public void DoesMenuWithNameAlreadyExistTest()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            
            Meni newMenu = MenuFactory.CreateMenu(1, "Fini Meni", "Jaje", "Mlinci i purica", "Medenjaci" );
            recRep.addMenu(newMenu);
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Fini Meni", "Proljetne rolice", "Biftek i povrce", "Creme brule");
            recRep.addMenu(newMenu2);


        }

        [TestMethod]
        public void CreatingThreeMenusTest()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            
            Meni newMenu = MenuFactory.CreateMenu(1, "Fini Meni", "Jaje", "Mlinci i purica", "Medenjaci");
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Jos bolji meni", "Proljetne rolice", "Biftek i povrce", "Creme brule");
            Meni newMenu3 = MenuFactory.CreateMenu(3, "njah meni", "Salata", "Spageti", "Cokolada");
            recRep.addMenu(newMenu);
            recRep.addMenu(newMenu2);
            recRep.addMenu(newMenu3);
            int quan = recRep.GetAllMenus().Count;
            Assert.AreEqual(3, quan);

        }

        [TestMethod]
        [ExpectedException(typeof(MenuAlreadyExists))]
        public void AddingTwoSameMenusTest()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Jos bolji meni", "Proljetne rolice", "Biftek i povrce", "Creme brule");
            recRep.addMenu(newMenu2);
            recRep.addMenu(newMenu2);


        }

        [TestMethod]
        [ExpectedException(typeof(MenuDoesntExist))]
        public void FindNoneExistingMenuByName()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Jos bolji meni", "Proljetne rolice", "Biftek i povrce", "Creme brule");
            recRep.addMenu(newMenu2);

            Meni recipe2 = recRep.getMenuByName("Biti ili ne biti.");
        }

        [TestMethod]
        public void GetMenuByID()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            Meni newMenu2 = MenuFactory.CreateMenu(2, "Jos bolji meni", "Proljetne rolice", "Biftek i povrce", "Creme brule");
            recRep.addMenu(newMenu2);
            Meni menu = recRep.getMenuByID(2);
            Assert.AreEqual(newMenu2, menu);
        }
       

        [TestMethod]
        public void DeleteMenuTest()
        {
            MenuRepository recRep = MenuRepository.getInstance();
            Meni newMenu2 = MenuFactory.CreateMenu(1, "Jos bolji meni", "Proljetne rolice", "Biftek i povrce", "Creme brule");
            recRep.addMenu(newMenu2);
            recRep.deleteMenu(1);
            Assert.AreEqual(0, recRep.GetAllMenus().Count);

        }

    }
}

