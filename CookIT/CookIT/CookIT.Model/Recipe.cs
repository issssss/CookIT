using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT.Model
{
    public class Recipe : EntityBase<int>
    {
		public static readonly int UndefinedRecipeID = -1;

		// SVI defaultno konstruirani računi će nakon kreiranja imati ID -1
		// na taj način ćemo u repozitoriju prepoznati da nisu inicijalizirani, pa ćemo im definirati ID kod dodavanja
		public Recipe() : base(UndefinedRecipeID)
		{
		}

		public Recipe(int inID, string inName, string recType, List<int> ingred, string recText) : base(inID)
		{
			Name = inName;
			Type = recType;
			Ingredients = ingred;
			Text = recText;

		}

		public string Name { get; set; }
		public string Type { get; set; }
		public List<int> Ingredients { get; set; }
		public string Text { get; set; }
	}
}
