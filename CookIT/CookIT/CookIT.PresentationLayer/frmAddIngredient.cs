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

namespace CookIT.PresentationLayer
{
    public partial class frmAddIngredient : Form, IAddNewIngredientView
    {
        public frmAddIngredient()
        {
            InitializeComponent();
        }

        public string IngredientName => txtIngredientName.Text;
        public float IngredientKcal
        {
            get
            {
                float kcalvalue = 0;
                if (Single.TryParse(textBox1.Text, out kcalvalue))
                    return kcalvalue;
                throw new ArgumentException();
            }
        }

        public float IngredientProteins
        {
            get
            {
                float value = 0;
                if (Single.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }

        public float IngredientCarbs
        {
            get
            {
                float value = 0;
                if (Single.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }
        public float IngredientFat
        {
            get
            {
                float value = 0;
                if (Single.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }
        public float IngredientFibers
        {
            get
            {
                float value = 0;
                if (Single.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }
        public float IngredientSodium
        {
            get
            {
                float value = 0;
                if (Single.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }

        public float IngredientMinerals
        {
            get
            {
                float value = 0;
                if (Single.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }

        public bool ShowModalView()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }


    }
}
