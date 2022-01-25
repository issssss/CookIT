using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model
{
    public class Ingredient : EntityBase<int>
    {

        public static readonly int UndefinedIngredientID = -1;

        public Ingredient() : base(UndefinedIngredientID)
        {

        }

        public Ingredient(int inID, string inName, float energy, float carbs, float proteins, float fats, float fibs, float salt, float minerals) : base(inID)
        {
            Name = inName;
            Kcal = energy;
            Proteins = proteins;
            Fat = fats;
            Carbs = carbs;
            Fibers = fibs;
            Sodium = salt;
            Minerals = minerals;
        }

        public string Name { get; set; }
        public float Kcal { get; set; }
        public float Proteins { get; set; }
        public float Fat { get; set; }
        public float Carbs { get; set; }
        public float Fibers { get; set; }
        public float Sodium { get; set; }
        public float Minerals { get; set; }

    }
}
