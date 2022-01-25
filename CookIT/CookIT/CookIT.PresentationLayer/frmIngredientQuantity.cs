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
using CookIT.BaseLib;
using CookIT.Model.Repositories;

namespace CookIT.PresentationLayer
{
    public partial class frmIngredientQuantity : Form, IAddIngredientQuantityView
    {
        List<string> _ingredients = null;
        IMainFormController _cont;
        IIngredientRepository _ing;
        List<TextBox> textBoxs = null;
        IAddNewRecipeView parentview = null;
        public frmIngredientQuantity()
        {
            InitializeComponent();
        }

        public void ShowModaless(IAddNewRecipeView view, List<string> ingreds, IMainFormController inMainController, IIngredientRepository ing)
        {
            _ingredients = ingreds;
            _cont = inMainController;
            _ing = ing;
            parentview = view;
            this.panel.RowCount = ingreds.Count;
            textBoxs = new List<TextBox>();
            for(int i = 0; i < ingreds.Count; i++)
            {
                Debug.WriteLine(ingreds[i]);
                this.panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                this.panel.Controls.Add(new Label() { Text = ingreds[i], AutoSize = true, Anchor = ((System.Windows.Forms.AnchorStyles.Top)| (System.Windows.Forms.AnchorStyles.Bottom))}, 0, i);
                textBoxs.Add(new TextBox());
                this.panel.Controls.Add(textBoxs[i], 1, i);
            }
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ingredQuant = new Dictionary<string, string>();
            for(int i = 0; i < _ingredients.Count; i++)
            {
                if (textBoxs[i].Text == null)
                {
                    MessageBox.Show("Write all the values!");
                    return;
                }
                ingredQuant.Add(_ingredients[i], textBoxs[i].Text);
            }
            _cont.GetQuanityForRecipe(parentview, ingredQuant);
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
