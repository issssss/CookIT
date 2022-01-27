using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;
using CookIT.Model;

namespace CookIT.BaseLib
{
    public interface IShowToMakeView
    {
        void ShowModaless(IMainFormController cont, List<Recipe> toMake);
    }
}
