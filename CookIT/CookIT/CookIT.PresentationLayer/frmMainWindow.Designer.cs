namespace CookIT.PresentationLayer
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.menusButton = new System.Windows.Forms.Button();
            this.recipesButton = new System.Windows.Forms.Button();
            this.getRecButton = new System.Windows.Forms.Button();
            this.addToMakeButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.logoName = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoName)).BeginInit();
            this.SuspendLayout();
            // 
            // menusButton
            // 
            this.menusButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.menusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menusButton.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.menusButton.Location = new System.Drawing.Point(484, 142);
            this.menusButton.Margin = new System.Windows.Forms.Padding(2);
            this.menusButton.Name = "menusButton";
            this.menusButton.Size = new System.Drawing.Size(235, 120);
            this.menusButton.TabIndex = 3;
            this.menusButton.Text = "Menus";
            this.menusButton.UseVisualStyleBackColor = false;
            this.menusButton.UseWaitCursor = true;
            // 
            // recipesButton
            // 
            this.recipesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.recipesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipesButton.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.recipesButton.Location = new System.Drawing.Point(154, 142);
            this.recipesButton.Margin = new System.Windows.Forms.Padding(2);
            this.recipesButton.Name = "recipesButton";
            this.recipesButton.Size = new System.Drawing.Size(235, 120);
            this.recipesButton.TabIndex = 3;
            this.recipesButton.Text = "Recipes";
            this.recipesButton.UseVisualStyleBackColor = false;
            this.recipesButton.Click += new System.EventHandler(this.addRecipeItem_Click);
            // 
            // getRecButton
            // 
            this.getRecButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.getRecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getRecButton.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRecButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.getRecButton.Location = new System.Drawing.Point(484, 290);
            this.getRecButton.Margin = new System.Windows.Forms.Padding(2);
            this.getRecButton.Name = "getRecButton";
            this.getRecButton.Size = new System.Drawing.Size(235, 120);
            this.getRecButton.TabIndex = 3;
            this.getRecButton.Text = "Recommendation";
            this.getRecButton.UseVisualStyleBackColor = false;
            this.getRecButton.Click += new System.EventHandler(this.getRecButton_Click);
            // 
            // addToMakeButton
            // 
            this.addToMakeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addToMakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToMakeButton.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToMakeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(163)))));
            this.addToMakeButton.Location = new System.Drawing.Point(154, 290);
            this.addToMakeButton.Margin = new System.Windows.Forms.Padding(2);
            this.addToMakeButton.Name = "addToMakeButton";
            this.addToMakeButton.Size = new System.Drawing.Size(235, 120);
            this.addToMakeButton.TabIndex = 3;
            this.addToMakeButton.Text = "To Make...";
            this.addToMakeButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CookIT.PresentationLayer.Properties.Resources.cookie;
            this.pictureBox2.Location = new System.Drawing.Point(800, 536);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CookIT.PresentationLayer.Properties.Resources.cookie;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 536);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // logoPic
            // 
            this.logoPic.Image = global::CookIT.PresentationLayer.Properties.Resources.CookBookNew;
            this.logoPic.Location = new System.Drawing.Point(345, 419);
            this.logoPic.Margin = new System.Windows.Forms.Padding(2);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(187, 175);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPic.TabIndex = 4;
            this.logoPic.TabStop = false;
            // 
            // logoName
            // 
            this.logoName.BackgroundImage = global::CookIT.PresentationLayer.Properties.Resources.CookIT;
            this.logoName.Image = global::CookIT.PresentationLayer.Properties.Resources.CookIT;
            this.logoName.InitialImage = global::CookIT.PresentationLayer.Properties.Resources.CookIT;
            this.logoName.Location = new System.Drawing.Point(302, -47);
            this.logoName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(262, 225);
            this.logoName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoName.TabIndex = 5;
            this.logoName.TabStop = false;
            // 
            // frmMainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(854, 591);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recipesButton);
            this.Controls.Add(this.menusButton);
            this.Controls.Add(this.addToMakeButton);
            this.Controls.Add(this.getRecButton);
            this.Controls.Add(this.logoPic);
            this.Controls.Add(this.logoName);
            this.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CookIT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button recipesButton;
        private System.Windows.Forms.Button menusButton;
        private System.Windows.Forms.Button addToMakeButton;
        private System.Windows.Forms.Button getRecButton;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logoName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}