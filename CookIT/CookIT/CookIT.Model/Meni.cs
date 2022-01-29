using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model
{
    public class Meni : EntityBase<int>
    {
        public static readonly int UndefinedMenuId = -1;
        public Meni() : base(UndefinedMenuId) { }

        public Meni(int ID, string name, List<Recipe> listOfCourses): base(ID)
        {
            Name = name;
            Entree = listOfCourses[0];
            MainCourse = listOfCourses[1];
            Dessert = listOfCourses[2];
        }

        public string Name { get; set; }
        public Recipe Entree { get; set; }
        public Recipe MainCourse { get; set; }
        public Recipe Dessert { get; set; }
    }
}
