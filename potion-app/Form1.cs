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
            LoadIngredients();
            LoadRecipes();
            LoadPotions();
        }

        private void LoadIngredients()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.GetIngredients();
        }

        private void LoadRecipes()
        {

        }

        private void LoadPotions()
        {

        }

        private void tabMain_Click(object sender, EventArgs e)
        {
            LoadIngredients();
            LoadRecipes();
            LoadPotions();
        }

        private void Stock_TextChanged(object sender, EventArgs e)
        {
            int stock;

            if (string.IsNullOrWhiteSpace(Stock.Text))
                return;

            if (!int.TryParse(Stock.Text, out stock) || stock < 0)
            {
                //Stock.BackColor = System.Drawing.Color.MistyRose;
            }
            else
            {
                //Stock.BackColor = System.Drawing.SystemColors.Window;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ingredient ingredient = new Ingredient();

                ingredient.Name = FindInput("Name");
                ingredient.Stock = int.Parse(Stock.Text);
                ingredient.Unit = FindInput("Unit");
                ingredient.Price = decimal.Parse(FindInput("Price"));

                repo.AddIngredient(ingredient);

                MessageBox.Show("Ingredient added successfully.");

                LoadIngredients();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid stock and price.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add ingredient: " + ex.Message);
            }
        }

        // Read an existing text box by its actual control name.
        private string FindInput(string controlName)
        {
            Control[] controls = Controls.Find(controlName, true);

            if (controls.Length == 0 || !(controls[0] is TextBox))
                throw new Exception(
                    "Could not find the text box named " + controlName +
                    ". Check its (Name) property in the Designer.");

            return controls[0].Text.Trim();
        }
    }
}
