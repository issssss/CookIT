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
    public partial class frmAddMenu : Form, IAddNewMenuView
    {
        private readonly List<Recipe> _recipeList = null;
        private readonly IMainFormController _controller;
        
        public frmAddMenu(IMainFormController incont, List<Recipe> recipes)
        {
            _recipeList = recipes;
            _controller = incont;


            InitializeComponent();
        }


        private void frmAddMenu_Load(object sender, EventArgs e)
        {
            foreach (Recipe s in _recipeList)
            {
                comboBox1.Items.Add(s.Name);
                comboBox2.Items.Add(s.Name);
                cmbRecipes.Items.Add(s.Name);
            }

        }
        private void addIngredientItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.AddIngredient();
            this.Show();

        }
        public string MenuName => txtMenuName.Text;
        public string Entree
        {
            get
            {

                if (cmbRecipes.SelectedItem == null)
                {
                    MessageBox.Show("Please choose an entree");
                    return null;
                }

                return cmbRecipes.SelectedItem.ToString();

            }
        }
        public string MainCourse
        {
            get
            {

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a main course.");
                    return null;
                }

                return comboBox1.SelectedItem.ToString();

            }
        }

        public string Desert
        {
            get
            {

                if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a desert.");
                    return null;
                }

                return comboBox2.SelectedItem.ToString();

            }
        }

        public bool ShowModalView()
        {
            if (this.ShowDialog() == DialogResult.OK)
            {
                if (MenuName == "" || Entree == null || MainCourse == null || Desert == null)
                {
                    MessageBox.Show("Please choose a name and the recipes for your courses.");
                   
                    return false;
                }
                return true;
            }
            else
                return false;
        }

    }
}
