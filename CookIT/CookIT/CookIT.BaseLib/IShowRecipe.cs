﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;

namespace CookIT.BaseLib
{
    public interface IShowRecipe
    {
        void showRecipe(int ID, IMainFormController cont, IRecipeRepository recrep, IIngredientRepository ingrep);
    }
}