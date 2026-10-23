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
            Unit = new TextBox();
            ingredient = new DataGridView();
            button1 = new Button();
            Stock = new TextBox();
            Price = new TextBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4Potion = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView2brew = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ingredient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2brew).BeginInit();
            SuspendLayout();
            // 
            // Unit
            // 
            Unit.Location = new Point(158, 14);
            Unit.Name = "Unit";
            Unit.Size = new Size(125, 27);
            Unit.TabIndex = 0;
            Unit.Text = "Unit";
            // 
            // ingredient
            // 
            ingredient.BackgroundColor = SystemColors.ButtonFace;
            ingredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingredient.Location = new Point(12, 12);
            ingredient.Name = "ingredient";
            ingredient.RowHeadersWidth = 51;
            ingredient.Size = new Size(300, 188);
            ingredient.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 4;
            button1.Text = "Add Ingredient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Stock
            // 
            Stock.Location = new Point(12, 57);
            Stock.Name = "Stock";
            Stock.Size = new Size(125, 27);
            Stock.TabIndex = 5;
            Stock.Text = "Stock";
            Stock.TextChanged += Stock_TextChanged;
            // 
            // Price
            // 
            Price.Location = new Point(158, 57);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 6;
            Price.Text = "Price";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(111, 379);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 8;
            comboBox2.Text = "Recipe";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(464, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 218);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(478, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Ingredient";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(478, 70);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 16;
            textBox6.Text = "Ingredient Quality";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(639, 23);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 17;
            textBox7.Text = "Description/Instructions";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(464, 23);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 18;
            textBox8.Text = "Recipe Name";
            // 
            // button2
            // 
            button2.Location = new Point(656, 172);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Add Ingredient to Recipe";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(607, 331);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 20;
            button3.Text = "Generate Report";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4Potion
            // 
            button4Potion.Location = new Point(369, 344);
            button4Potion.Name = "button4Potion";
            button4Potion.Size = new Size(94, 29);
            button4Potion.TabIndex = 21;
            button4Potion.Text = "Delete Potion";
            button4Potion.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(-1, 379);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 22;
            button5.Text = "Start Brewing";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(670, 111);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 23;
            button6.Text = "Add Recipe";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2brew
            // 
            dataGridView2brew.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2brew.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2brew.Location = new Point(-1, 206);
            dataGridView2brew.Name = "dataGridView2brew";
            dataGridView2brew.RowHeadersWidth = 51;
            dataGridView2brew.Size = new Size(300, 167);
            dataGridView2brew.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(dataGridView2brew);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4Potion);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(Price);
            Controls.Add(Stock);
            Controls.Add(Unit);
            Controls.Add(button1);
            Controls.Add(ingredient);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ingredient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2brew).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Unit;
        private DataGridView ingredient;
        private Button button1;
        private TextBox Stock;
        private TextBox Price;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button2;
        private Button button3;
        private Button button4Potion;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView2brew;
    }
}
