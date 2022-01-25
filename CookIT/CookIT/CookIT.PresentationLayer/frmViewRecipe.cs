using CookIT.BaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookIT.Model;
using CookIT.Model.Repositories;

namespace CookIT.PresentationLayer
{
    public partial class frmViewRecipes : Form, IViewRecipesView
    {
        private IMainFormController _controller = null;
        private IRecipeRepository _repository = null;
        private List<Recipe> _recipeList = null;
        public frmViewRecipes()
        {
            InitializeComponent();
        }
        public void ShowModaless(IMainFormController inMainController, IRecipeRepository inListRec)
        {
            _controller = inMainController;
            _repository = inListRec;
            _recipeList = inListRec.GetAllRecipes();

            UpdateList();

            this.Show();
        }


        private void addRecipeItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.AddRecipe();
            _recipeList = this._repository.GetAllRecipes();
            UpdateList();
            this.Show();
        }

        private void UpdateList()
        {
            for (int i = 0; i < _recipeList.Count(); i++)
            {
                Recipe acc = _recipeList[i];
            
                string accType = acc.Type;
                if (recipeList.Items.ContainsKey(acc.Name))
                    continue;
              
                ListViewItem lvt = new ListViewItem(acc.Name);
                lvt.Name = acc.Name;
                lvt.SubItems.Add(accType);

                recipeList.Items.Add(lvt);
            }
        }

        private void recipeList_DoubleClick(object sender, EventArgs e)
        {
            if (recipeList.SelectedItems[0] != null)
            {
             
                string name = recipeList.SelectedItems[0].Text;
                int ind = _repository.getRecipeByName(name).Id;

                _controller.ShowRecipe(ind);
    
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Recipe_Click(object sender, EventArgs e)
        {
            if(recipeList.SelectedItems[0] != null)
            {
                string name = recipeList.SelectedItems[0].Text;
                int ind = _repository.getRecipeByName(name).Id;

                _controller.DeleteRecipe(ind);
                recipeList.Items.Clear();
                UpdateList();
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
                MessageBox.Show("No such recipe... :(");
            }
        }

    }
}
