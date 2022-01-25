using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model.Repositories
{
    public interface IIngredientRepository
    {
        int getNewId();
        Ingredient getIngredientByID(int inRecID);
        Ingredient getIngredientByName(string recName);

        List<int> getAllIngredientIDs();
        List<String> GetAllIngredientNames();
        List<Ingredient> GetAllIngredients();
        void addIngredient(Ingredient addRec);

    }
}
