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
        public int IngredientKcal
        {
            get
            {
                int kcalvalue = 0;
                if (Int32.TryParse(textBox1.Text, out kcalvalue))
                    return kcalvalue;
                throw new ArgumentException();
            }
        }

        public int IngredientProteins
        {
            get
            {
                int value = 0;
                if (Int32.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }

        public int IngredientCarbs
        {
            get
            {
                int value = 0;
                if (Int32.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }
        public int IngredientFat
        {
            get
            {
                int value = 0;
                if (Int32.TryParse(textBox1.Text, out value))
                    return value;
                throw new ArgumentException();
            }
        }
        public int IngredientFibers
        {
            get
            {
                int value = 0;
                if (Int32.TryParse(textBox1.Text, out value))
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
