
namespace CookIT.PresentationLayer
{
    partial class frmAddRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRecipe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.cmbRecipeType = new System.Windows.Forms.ComboBox();
            this.txtRecipeText = new System.Windows.Forms.TextBox();
            this.ingredientList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.logoName = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recipe Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recipe Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ingredients";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(177, 508);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add recipe";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(671, 508);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(621, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add New Ingredient";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.addIngredientItem_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.txtRecipeName.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.txtRecipeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRecipeName.Location = new System.Drawing.Point(177, 21);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(472, 27);
            this.txtRecipeName.TabIndex = 0;
            // 
            // cmbRecipeType
            // 
            this.cmbRecipeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.cmbRecipeType.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.cmbRecipeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRecipeType.FormattingEnabled = true;
            this.cmbRecipeType.Location = new System.Drawing.Point(177, 61);
            this.cmbRecipeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRecipeType.Name = "cmbRecipeType";
            this.cmbRecipeType.Size = new System.Drawing.Size(176, 28);
            this.cmbRecipeType.TabIndex = 1;
            this.cmbRecipeType.Text = "--Select--";
            // 
            // txtRecipeText
            // 
            this.txtRecipeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.txtRecipeText.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.txtRecipeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRecipeText.Location = new System.Drawing.Point(177, 261);
            this.txtRecipeText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeText.Multiline = true;
            this.txtRecipeText.Name = "txtRecipeText";
            this.txtRecipeText.Size = new System.Drawing.Size(609, 234);
            this.txtRecipeText.TabIndex = 2;
            // 
            // ingredientList
            // 
            this.ingredientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.ingredientList.CheckBoxes = true;
            this.ingredientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ingredientList.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.ingredientList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ingredientList.GridLines = true;
            this.ingredientList.HideSelection = false;
            this.ingredientList.LabelEdit = true;
            this.ingredientList.LabelWrap = false;
            this.ingredientList.Location = new System.Drawing.Point(177, 100);
            this.ingredientList.Name = "ingredientList";
            this.ingredientList.Size = new System.Drawing.Size(414, 149);
            this.ingredientList.TabIndex = 11;
            this.ingredientList.UseCompatibleStateImageBehavior = false;
            this.ingredientList.View = System.Windows.Forms.View.Details;
            this.ingredientList.DoubleClick += new System.EventHandler(this.ingredientList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 409;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(621, 215);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "Add Quantity";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // logoName
            // 
            this.logoName.BackgroundImage = global::CookIT.PresentationLayer.Properties.Resources.CookIT;
            this.logoName.Image = global::CookIT.PresentationLayer.Properties.Resources.CookIT;
            this.logoName.InitialImage = global::CookIT.PresentationLayer.Properties.Resources.CookIT;
            this.logoName.Location = new System.Drawing.Point(669, -21);
            this.logoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(172, 155);
            this.logoName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoName.TabIndex = 9;
            this.logoName.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CookIT.PresentationLayer.Properties.Resources.cookie;
            this.pictureBox2.Location = new System.Drawing.Point(810, 512);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CookIT.PresentationLayer.Properties.Resources.cookie;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 512);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(853, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ingredientList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.logoName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRecipeText);
            this.Controls.Add(this.cmbRecipeType);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Recipe";
            this.Load += new System.EventHandler(this.frmAddRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.ComboBox cmbRecipeType;
        private System.Windows.Forms.TextBox txtRecipeText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logoName;
        private System.Windows.Forms.ListView ingredientList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button4;
    }
}