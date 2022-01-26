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

        public Meni(int ID, string name, string entree, string main_cour, string desert): base(ID)
        {
            Name = name;
            Entree = entree;
            MainCourse = main_cour;
            Desert = desert;
        }

        public string Entree { get; set; }
        public string Name { get; set; }
        public string MainCourse { get; set; }
        public string Desert { get; set; }
    }
}
