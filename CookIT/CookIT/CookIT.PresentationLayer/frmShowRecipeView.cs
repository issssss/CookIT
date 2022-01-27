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
using CookIT.Model;

namespace CookIT.PresentationLayer
{
    public partial class frmShowRecipeView : Form, IShowRecipe
    {
        private Recipe _recipe;
        private IMainFormController _cont;

        public frmShowRecipeView()
        {
            InitializeComponent();
        }

        public void showRecipe(int ID, IMainFormController cont, Recipe recipe)
        {
            Dictionary<string, string> ingredInd = new Dictionary<string, string>();
            _recipe = recipe;
            _cont = cont;
            ingredInd = _recipe.Ingredients;
            List<Ingredient> ingreNames = new List<Ingredient>();

            foreach (string ind in ingredInd.Keys)
            {

                ListViewItem lv = new ListViewItem(ind);
                lv.Name = ind;
                lv.SubItems.Add(ingredInd[ind]);
                ingredientList.Items.Add(lv);

            }
            this.txtRecipeText.Text = _recipe.Text;
            this.label1.Text = _recipe.Name;
            if (_recipe.Grade != "") this.txtRecipeGrade.Text = _recipe.Grade;
            this.label4.Text = _cont.calculateSumOfCalories(ID).ToString();
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

        private void ingredientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                _cont.ShowIngredient(ingredientList.SelectedItems[0].Text);
           
  
        }
    }
}