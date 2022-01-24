using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookIT.BaseLib;
using CookIT.Model.Repositories;
using CookIT.Model;

namespace CookIT.PresentationLayer
{
    public partial class frmShowRecipeView : Form, IShowRecipe
    {
        private Recipe _recipe;
        private IMainFormController _cont;
        private IRecipeRepository _recrep;
        public frmShowRecipeView()
        {
            InitializeComponent();
        }

        public void showRecipe(int ID, IMainFormController cont, IRecipeRepository recrep, IIngredientRepository ingrep)
        {
            List<int> ingredInd = new List<int>();
            _recipe = recrep.getRecipeByID(ID);
            _cont = cont;
            _recrep = recrep;
            ingredInd = _recipe.Ingredients;
            List<Ingredient> ingreNames = new List<Ingredient>();

            foreach(int ind in ingredInd)
            {
                Ingredient ingre = ingrep.getIngredientByID(ind);
                ingreNames.Add(ingre);
                ListViewItem lv = new ListViewItem(ingre.Name);
                lv.Name = ingre.Name;
                ingredientList.Items.Add(lv);
                
            }
            this.txtRecipeText.Text = _recipe.Text;
            this.label1.Text = _recipe.Name;
            this.Show();
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_recipe_Click(object sender, EventArgs e)
        {
            string newText = this.txtRecipeText.Text;
            Recipe changedRec = new Recipe(_recipe.Id, _recipe.Name, _recipe.Type, _recipe.Ingredients, newText);
            _cont.EditRecipe(_recipe.Id,changedRec);
            _recipe = changedRec;
            this.Close();

        }

    
    }
}
