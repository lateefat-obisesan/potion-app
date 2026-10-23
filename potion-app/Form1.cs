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

        }
    }
}
