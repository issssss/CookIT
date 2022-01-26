using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.BaseLib
{
    public interface IAddNewMenuView
    {
        bool ShowModalView();
        string MenuName { get; }
        string Entree { get; }
        string MainCourse { get; }
        string Desert { get; }

    }
}
