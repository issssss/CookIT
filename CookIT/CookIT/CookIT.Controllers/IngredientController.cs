using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CookIT.Model;
using CookIT.Model.Factories;
using CookIT.Model.Repositories;
using CookIT.BaseLib;

namespace CookIT.Controllers
{
    public class IngredientController : IIngredientController
    {
        public void AddNewIngredient(IAddNewIngredientView inForm, IIngredientRepository repository)
        {
            if(inForm.ShowModalView() == true)
            try
            {
                    string Name = inForm.IngredientName;
                    float Kcal = inForm.IngredientKcal;
                    float Proteins = inForm.IngredientProteins;
                    float Fats = inForm.IngredientFat;
                    float Carbs = inForm.IngredientCarbs;
                    float Fibers = inForm.IngredientFibers;
                    float Sodium = inForm.IngredientSodium;
                    float Minerals = inForm.IngredientMinerals;
                    int ID = repository.getNewId();

                    Ingredient newIngredient = IngredientFactory.CreateIngredient(ID, Name, Kcal, Carbs, Proteins, Fats, Fibers, Sodium, Minerals);
                    repository.addIngredient(newIngredient);

            }
            catch(Exception e)
            {
                    if (e is IngredientAlreadyExists)
                        MessageBox.Show("The ingredient name is already taken.");
                   // MessageBox.Show("The ingredient values are incorrect.");
                    AddNewIngredient(inForm, repository);
                    return;
            }
        }


        public void ShowIngredient(IShowIngredientView ingredientView, string name, IIngredientRepository ingredRep)
        {
            Ingredient ingredient = ingredRep.getIngredientByName(name);
            ingredientView.showIngredient(ingredient);
        }
    }
}
