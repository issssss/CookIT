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
            Dictionary<string, string> ingredInd = new Dictionary<string, string>();
            _recipe = recrep.getRecipeByID(ID);
            _cont = cont;
            _recrep = recrep;
            ingredInd = _recipe.Ingredients;
            List<Ingredient> ingreNames = new List<Ingredient>();

            foreach(string ind in ingredInd.Keys)
            {
                Ingredient ingre = ingrep.getIngredientByName(ind);
                ingreNames.Add(ingre);
                ListViewItem lv = new ListViewItem(ingre.Name);
                lv.Name = ingre.Name;
                lv.SubItems.Add(ingredInd[ind]);
                ingredientList.Items.Add(lv);
                
            }
            this.txtRecipeText.Text = _recipe.Text;
            this.label1.Text = _recipe.Name;
            if (_recipe.Grade != "") this.txtRecipeGrade.Text = _recipe.Grade;
            this.label4.Text = recrep.calculateSumOfCalories(ID).ToString();
            this.Show();
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_recipe_Click(object sender, EventArgs e)
        {
            string grade = null;
            string newText = this.txtRecipeText.Text;
            if (this.txtRecipeGrade.Text != null)
                grade = this.txtRecipeGrade.Text;
            _cont.EditRecipe(_recipe.Id, newText, grade);
            //_recipe = changedRec;
            this.Close();

        }

    
    }
}
