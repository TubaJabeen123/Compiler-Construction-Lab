using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGridView
{
    public partial class gridView : Form
    {
        public gridView()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        // Initialize DataGridView with columns
        private void InitializeDataGridView()
        {
            // Clear any existing columns
            dataGridView1.Columns.Clear();

            // Add columns to DataGridView
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
        }

        // Event handler to add a row to DataGridView
        private void AddRowToDataGridView(string column1Value, string column2Value, string column3Value)
        {
            dataGridView1.Rows.Add(column1Value, column2Value, column3Value);
        }

        // Event handler for Add Row button click
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            // Read values from TextBoxes
            string column1Value = textBox1.Text;
            string column2Value = textBox2.Text;
            string column3Value = textBox3.Text;

            // Clear text boxes after adding the row
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            // Add row to DataGridView
            AddRowToDataGridView(column1Value, column2Value, column3Value);
        }

        // Load event to ensure DataGridView is initialized
        private void gridView_Load(object sender, EventArgs e)
        {
            // Any additional setup can be done here
        }
    }
}
