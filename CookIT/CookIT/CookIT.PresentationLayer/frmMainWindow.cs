﻿using System;
using System.Windows.Forms;

using CookIT.Model;
using CookIT.Controllers;

namespace CookIT.PresentationLayer
{
	public partial class frmMainWindow : Form
	{
		private readonly MainFormController _controller;

		public frmMainWindow(MainFormController inController)
		{
			_controller = inController;

			InitializeComponent();
		}

		

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

		private void addRecipeItem_Click(object sender, EventArgs e)
		{
			_controller.ViewRecipes();
		}

        private void getRecButton_Click(object sender, EventArgs e)
        {

        }
    }
}