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
    public partial class frmShowIngredient : Form, IShowIngredientView
    {
        public frmShowIngredient()
        {
            InitializeComponent();
        }

        public void showIngredient(Ingredient ingredient)
        {
            label1.Text = ingredient.Name;
            label4.Text = ingredient.Kcal.ToString();
            label10.Text = ingredient.Proteins.ToString();
            label11.Text = ingredient.Fat.ToString();
            label12.Text = ingredient.Carbs.ToString();
            label13.Text = ingredient.Fibers.ToString();
            label14.Text = ingredient.Sodium.ToString();
            label22.Text = ingredient.Minerals.ToString();

            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
