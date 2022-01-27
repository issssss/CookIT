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
    public partial class frmToMakeView : Form, IShowToMakeView
    {
        
        IMainFormController _cont = null;
        List<Recipe> _toMakeList = null;
        public frmToMakeView()
        {
            InitializeComponent();
        }

        public void ShowModaless(IMainFormController cont, List<Recipe> toMake)
        {
           
            _cont = cont;
            _toMakeList = toMake;
            UpdateList();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbRecipes.SelectedItem != null)
            {
                int ind = cmbRecipes.SelectedIndex;
                Recipe recipe = _cont.GetAllRecipes()[ind];
                _cont.AddToMakeList(recipe.Id);
                _toMakeList = _cont.GetToMakeList();
                recipeList.Items.Clear();
                UpdateList();
            }
            else
            {
                MessageBox.Show("Please choose a recipe to add.");
            }
        }

        private void UpdateList()
        {
            //recipeList.Items.Clear();
            foreach (Recipe r in _toMakeList)
            {
                if (recipeList.Items.ContainsKey(r.Name))
                    continue;
                ListViewItem lv = new ListViewItem();
                lv.Name = r.Name;
                lv.Text = r.Name;
                lv.SubItems.Add(r.Type);
                recipeList.Items.Add(lv);
            }
            this.Show();
        }

        private void frmRecipes_Load(object sender, EventArgs e) {

           List<Recipe> allRecipes = _cont.GetAllRecipes();
            foreach (Recipe r in allRecipes)
                cmbRecipes.Items.Add(r.Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(recipeList.SelectedItems.Count > 0)
            {
                int ind = recipeList.SelectedIndices[0];
                Recipe recipe = _toMakeList[ind];
                _cont.RemoveFromToMakeList(recipe.Id);
                _toMakeList = _cont.GetToMakeList();
                recipeList.Items.Clear();
                UpdateList();
            }
            else
            {
                MessageBox.Show("Please choose a recipe before removing.");
            }
        }

        private void recipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(recipeList.SelectedItems.Count > 0)
            {
                int ind = recipeList.SelectedIndices[0];
                Recipe recipe = _toMakeList[ind];
                _cont.ShowRecipe(recipe.Id);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Call FindItemWithText with the contents of the textbox.
            ListViewItem foundItem =
                recipeList.FindItemWithText(searchBox.Text, false, 0, true);
            if (foundItem != null)
            {
                recipeList.TopItem = foundItem;
                recipeList.Items.Clear();
                recipeList.Items.Add(foundItem);
                UpdateList();
            }
            else
            {
                MessageBox.Show("No such menu... :(");
            }
        }
    }


}
