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



namespace CookIT.PresentationLayer
{
    public partial class frmAddRecipe : Form, IAddNewRecipeView
    {
        private readonly List<string> _recipeTypes = null;
        private readonly IMainFormController _controller;
        private Dictionary<string, string> ingredientQuantity = null;
        public frmAddRecipe(List<string> recipeTypes, IMainFormController incont)
        {
            _recipeTypes = recipeTypes;
            _controller = incont;


            InitializeComponent();
            UpdateList();
        }


        private void frmAddRecipe_Load(object sender, EventArgs e)
        {
            cmbRecipeType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRecipeType.AutoCompleteSource = AutoCompleteSource.ListItems;
            foreach (string s in _recipeTypes)
            {
                if (cmbRecipeType.Items.Contains(s)) continue;
                cmbRecipeType.Items.Add(s);
            }

        }
        private void addIngredientItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.AddIngredient();
            UpdateList();
            this.Show();

        }
        public string RecipeName {
            get
            {
                if (txtRecipeName.Text == "")
                {
                    MessageBox.Show("The name of the recipe is empty.");
                    throw new ArgumentException();

                }
                
                return txtRecipeName.Text;
            }
        }
        public string RecipeType
        {
            get
            {

                if (cmbRecipeType.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a type of the recipe.");
                    throw new ArgumentException();
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
                
                return true;
            }
            else
                return false;
        }

        private void UpdateList()
        {
            List<Ingredient> _ingredientList = _controller.GetAllIngredients();

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
            if (ingredientList.CheckedItems.Count < 1)
            {
                MessageBox.Show("Please choose at least one ingredient.");
                return;
            }
            foreach (ListViewItem item in ingredientList.CheckedItems)
            {
                ingredNames.Add(item.Name);
            }
            _controller.GetIngredientQuant(this,ingredNames);
            UpdateList();

  
        }

        public void SaveQuantity(Dictionary<string, string> values)
        {
            ingredientQuantity = values;
           
        }

        private void ingredientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                _controller.ShowIngredient(ingredientList.SelectedItems[0].Text);

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListViewItem foundItem =
               ingredientList.FindItemWithText(textBox1.Text, false, 0, true);
            if (foundItem != null)
            {
                ingredientList.TopItem = foundItem;
                ingredientList.Items.Clear();
                ingredientList.Items.Add(foundItem);
                UpdateList();
            }
            else
            {
                MessageBox.Show("No such ingredient... :(");
            }
        }
    }
}
