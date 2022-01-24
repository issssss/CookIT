using System;

namespace CookIT.Model
{
	[Serializable]
	public class CookITBaseException : Exception
	{
	}


	public class RecipeDoesntExist : CookITBaseException
	{
	}

	public class RecipeAlreadyExists : CookITBaseException
	{
	}

	public class IngredientAlreadyExists : CookITBaseException
	{
	}

	public class IngredientDoesntExist : CookITBaseException
	{
	}
}