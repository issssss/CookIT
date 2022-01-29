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
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbRecipes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRecipes.AutoCompleteSource = AutoCompleteSource.ListItems;
            foreach (Recipe s in _recipeList)
            {
                if (comboBox1.Items.Contains(s.Name))
                    continue;
                comboBox1.Items.Add(s.Name);
                comboBox2.Items.Add(s.Name);
                cmbRecipes.Items.Add(s.Name);
            }

        }
      
        public string MenuName => txtMenuName.Text;
        public string Entree
        {
            get
            {

                if (cmbRecipes.SelectedItem == null)
                {
                    MessageBox.Show("Please choose an entree");
                    throw new ArgumentException();
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
                    throw new ArgumentException();
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
                    throw new ArgumentException();
                }

                return comboBox2.SelectedItem.ToString();

            }
        }

        public bool ShowModalView()
        {
            if (this.ShowDialog() == DialogResult.OK)
            {
                
                return true;
            }
            else
                return false;
        }

    }
}
