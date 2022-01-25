using System;

namespace CookIT.Model
{
	[Serializable]
	public class CookITBaseException : Exception
	{
	}

	[Serializable]
	public class RecipeDoesntExist : CookITBaseException
	{
	}
	[Serializable]
	public class RecipeAlreadyExists : CookITBaseException
	{
	}
	[Serializable]
	public class IngredientAlreadyExists : CookITBaseException
	{
	}
	[Serializable]
	public class IngredientDoesntExist : CookITBaseException
	{
	}
}