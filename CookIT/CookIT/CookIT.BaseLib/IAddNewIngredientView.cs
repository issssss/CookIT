using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.BaseLib
{
    public interface IAddNewIngredientView
    {
        bool ShowModalView();

        string IngredientName { get; }
        int IngredientKcal { get; }
        int IngredientProteins { get; }
        int IngredientCarbs { get; }
        int IngredientFat { get; }
        int IngredientFibers { get; }
        float IngredientSodium { get; }
        float IngredientMinerals { get; }
    }
}
