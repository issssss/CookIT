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
    public class IngredientController
    {
        public void AddNewIngredient(IAddNewIngredientView inForm, IIngredientRepository repository)
        {
            if(inForm.ShowModalView() == true)
            try
            {
                    string Name = inForm.IngredientName;
                    int Kcal = inForm.IngredientKcal;
                    int Proteins = inForm.IngredientProteins;
                    int Fats = inForm.IngredientFat;
                    int Carbs = inForm.IngredientCarbs;
                    int Fibers = inForm.IngredientFibers;
                    float Sodium = inForm.IngredientSodium;
                    float Minerals = inForm.IngredientMinerals;
                    int ID = repository.getNewId();

                    Ingredient newIngredient = IngredientFactory.CreateIngredient(ID, Name, Kcal, Carbs, Proteins, Fats, Fibers, Sodium, Minerals);
                    repository.addIngredient(newIngredient);

            }
            catch(Exception e)
            {
                    MessageBox.Show("Exeption: " + e.Message);
                    throw;
            }
        }

        public void ShowIngredients(IShowIngredientsView showIngredients, IIngredientRepository ingRepository, IMainFormController cont)
        {
            showIngredients.ShowModaless(cont, ingRepository);
        }
    }
}
