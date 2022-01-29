using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookIT.Model.Repositories;

namespace CookIT.BaseLib
{
    public interface IIngredientController
    {
        void AddNewIngredient(IAddNewIngredientView inForm, IIngredientRepository repository);
        void ShowIngredient(IShowIngredientView ingredientView, string name, IIngredientRepository ingredRep);
    }
}
