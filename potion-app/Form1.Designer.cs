namespace potion_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            tabControl1 = new TabControl();
            tabMain = new TabPage();
            label1 = new Label();
            Ingredients = new TabPage();
            Recipe = new TabPage();
            Brew = new TabPage();
            Potions = new TabPage();
            Reports = new TabPage();
            tabControl1.SuspendLayout();
            tabMain.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 228);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMain);
            tabControl1.Controls.Add(Ingredients);
            tabControl1.Controls.Add(Recipe);
            tabControl1.Controls.Add(Brew);
            tabControl1.Controls.Add(Potions);
            tabControl1.Controls.Add(Reports);
            tabControl1.Location = new Point(69, 147);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(655, 214);
            tabControl1.TabIndex = 2;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(label1);
            tabMain.Location = new Point(4, 29);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(3);
            tabMain.Size = new Size(647, 181);
            tabMain.TabIndex = 0;
            tabMain.Text = "tabPage1";
            tabMain.UseVisualStyleBackColor = true;
            tabMain.Click += tabMain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 83);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Ingredients
            // 
            Ingredients.Location = new Point(4, 29);
            Ingredients.Name = "Ingredients";
            Ingredients.Padding = new Padding(3);
            Ingredients.Size = new Size(647, 181);
            Ingredients.TabIndex = 1;
            Ingredients.Text = "tabPage2";
            Ingredients.UseVisualStyleBackColor = true;
            // 
            // Recipe
            // 
            Recipe.Location = new Point(4, 29);
            Recipe.Name = "Recipe";
            Recipe.Size = new Size(647, 181);
            Recipe.TabIndex = 2;
            Recipe.Text = "Recipe";
            Recipe.UseVisualStyleBackColor = true;
            // 
            // Brew
            // 
            Brew.Location = new Point(4, 29);
            Brew.Name = "Brew";
            Brew.Size = new Size(647, 181);
            Brew.TabIndex = 3;
            Brew.Text = "tabPage2";
            Brew.UseVisualStyleBackColor = true;
            // 
            // Potions
            // 
            Potions.Location = new Point(4, 29);
            Potions.Name = "Potions";
            Potions.Size = new Size(647, 181);
            Potions.TabIndex = 4;
            Potions.Text = "tabPage3";
            Potions.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            Reports.Location = new Point(4, 29);
            Reports.Name = "Reports";
            Reports.Size = new Size(647, 181);
            Reports.TabIndex = 5;
            Reports.Text = "tabPage4";
            Reports.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TabControl tabControl1;
        private TabPage Ingredients;
        public TabPage tabMain;
        private Label label1;
        private TabPage Recipe;
        private TabPage Brew;
        private TabPage Potions;
        private TabPage Reports;
    }
}
