using potion_app.Models;
using potion_app.Repo;

namespace potion_app
{
    public partial class Form1 : Form
    {
        private DataRepo repo = new DataRepo();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repo.GetIngredients();

            comboBox1.DataSource = repo.GetRecipes();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void tabMain_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.GetIngredients();

            comboBox1.DataSource = null;
            comboBox1.DataSource = repo.GetRecipes();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void Stock_TextChanged(object sender, EventArgs e)
        {
            int stock;

            if (Stock.Text != "" && !int.TryParse(Stock.Text, out stock))
            {
                MessageBox.Show("Stock must be a number.");
                Stock.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Recipe recipe)
            {
                MessageBox.Show(
                    "Recipe: " + recipe.Name +
                    "\nEffect: " + recipe.Effect +
                    "\nTime: " + recipe.Duration + " seconds");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox nameBox = null;
                TextBox stockBox = null;
                TextBox unitBox = null;
                TextBox priceBox = null;

                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        if (control.Text == "Name")
                            nameBox = (TextBox)control;
                    }
                }

                nameBox = FindTextBox("Name");
                stockBox = FindTextBox("Stock");
                unitBox = FindTextBox("Unit");
                priceBox = FindTextBox("Price");

                Ingredient ingredient = new Ingredient();
                ingredient.Name = nameBox.Text.Trim();
                ingredient.Stock = int.Parse(stockBox.Text);
                ingredient.Unit = unitBox.Text.Trim();
                ingredient.Price = decimal.Parse(priceBox.Text);

                repo.AddIngredient(ingredient);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.GetIngredients();

                MessageBox.Show("Ingredient added successfully.");

                nameBox.Clear();
                stockBox.Clear();
                unitBox.Clear();
                priceBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the ingredient details: " + ex.Message);
            }
        }

        private TextBox FindTextBox(string controlName)
        {
            Control[] found = Controls.Find(controlName, true);

            if (found.Length == 0 || !(found[0] is TextBox))
                throw new Exception("TextBox not found: " + controlName);

            return (TextBox)found[0];
        }
    }
}
