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

        public Ingredient(int inID, string inName, int energy, int carbs, int proteins, int fats, int fibs, float salt, float minerals) : base(inID)
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
        public int Kcal { get; set; }
        public int Proteins { get; set; }
        public int Fat { get; set; }
        public int Carbs { get; set; }
        public int Fibers { get; set; }
        public float Sodium { get; set; }
        public float Minerals { get; set; }

    }
}
