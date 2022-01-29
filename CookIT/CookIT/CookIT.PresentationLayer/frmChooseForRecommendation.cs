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

namespace CookIT.PresentationLayer
{
    public partial class frmChooseForRecommendation : Form, IChooseForRecommendationView
    {
        private readonly IMainFormController _controller = null;
        private readonly List<string> _ingredients = null;
        private readonly List<string> _recipeTypes = null;

        public frmChooseForRecommendation(List<string> types, IMainFormController cont, List<string> ingrep)
        {
            _controller = cont;
            _ingredients = ingrep;
            _recipeTypes = types;
            InitializeComponent();
        }

        public bool ShowModalView()
        {
            if(this.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private void frmChoose_Load(object sender, EventArgs e)
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbRecipes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRecipes.AutoCompleteSource = AutoCompleteSource.ListItems;
            foreach (string s in _recipeTypes)
                cmbRecipes.Items.Add(s);
            foreach (string s in _ingredients)
                comboBox1.Items.Add(s);
        }

        public string Type
        {
            get
            {

                if (cmbRecipes.SelectedItem == null)
                {
                    
                    return "";
                }

                return cmbRecipes.SelectedItem.ToString();

            }
        }

        public string Ingredient
        {
            get
            {

                if (comboBox1.SelectedItem == null)
                {

                    return "";
                }

                return comboBox1.SelectedItem.ToString();

            }
        }
    }

}
