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
        float IngredientKcal { get; }
        float IngredientProteins { get; }
        float IngredientCarbs { get; }
        float IngredientFat { get; }
        float IngredientFibers { get; }
        float IngredientSodium { get; }
        float IngredientMinerals { get; }
    }
}
