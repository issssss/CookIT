using CookIT.BaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookIT.Model;
using CookIT.Model.Repositories;


namespace CookIT.PresentationLayer
{
    public partial class frmAddRecipe : Form, IAddNewRecipeView
    {
        private readonly List<string> _recipeTypes = null;
        private readonly IMainFormController _controller;
        private IIngredientRepository _ingredientRepository = null;
        private Dictionary<string, string> ingredientQuantity = null;
        public frmAddRecipe(List<string> recipeTypes, IMainFormController incont, IIngredientRepository ingrep)
        {
            _recipeTypes = recipeTypes;
            _controller = incont;
            _ingredientRepository = ingrep;


            InitializeComponent();
            UpdateList();
        }


        private void frmAddRecipe_Load(object sender, EventArgs e)
        {
            foreach (string s in _recipeTypes)
                cmbRecipeType.Items.Add(s);

        }
        private void addIngredientItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.AddIngredient();
            UpdateList();
            this.Show();

        }
        public string RecipeName => txtRecipeName.Text;
        public string RecipeType
        {
            get
            {

                if (cmbRecipeType.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a type of the recipe.");
                    return null;
                }

                return cmbRecipeType.SelectedItem.ToString();

            }
        }

        public Dictionary<string, string> RecipeIngred => ingredientQuantity;


        public string RecipeText => txtRecipeText.Text;

        public bool ShowModalView()
        {
            if (this.ShowDialog() == DialogResult.OK)
            {
                if (RecipeName == null || RecipeType == null || RecipeIngred == null)
                {
                    MessageBox.Show("Please fill in the recipe form, including the ingredients quantity.");
                   
                    return false;
                }
                return true;
            }
            else
                return false;
        }

        private void UpdateList()
        {
            List<Ingredient> _ingredientList = _ingredientRepository.GetAllIngredients();

            for (int i = 0; i < _ingredientList.Count(); i++)
            {
                Ingredient acc = _ingredientList[i];

            
                if (ingredientList.Items.ContainsKey(acc.Name))
                    continue;

                ListViewItem lvt = new ListViewItem(acc.Name);
                lvt.Name = acc.Name;
                if(ingredientQuantity != null)
                {
                    lvt.SubItems.Add(ingredientQuantity[lvt.Name]);
                }

                ingredientList.Items.Add(lvt);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            List<string> ingredNames = new List<string>();
            if (ingredientList.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please choose at least one ingredient.");
                return;
            }
            foreach (ListViewItem item in ingredientList.SelectedItems)
            {
                ingredNames.Add(item.Name);
            }
            _controller.GetIngredientQuant(this,ingredNames);
            UpdateList();

  
        }

        public void SaveQuantity(Dictionary<string, string> values)
        {
            ingredientQuantity = values;
            //InitializeComponent();
            UpdateList();
        }
    }
}
