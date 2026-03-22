using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;

namespace WinFormsOnlineBookshop
{
    public partial class Form1 : Form
    {
        private AuthorBusiness authorBusiness = new AuthorBusiness();
        private BookBusiness bookBusiness = new BookBusiness();
        private CustomerBusiness customerBusiness = new CustomerBusiness();
        private OrderBusiness orderBusiness = new OrderBusiness();

        private int flag = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            flag = 1;
            ClearTextBoxes();

            //Set the unused labels/textboxes to invisible
            label1.Visible = true;
            txtBirthYear.Visible = true;

            label2.Visible = true;
            txtFirstName.Visible = true;

            label3.Visible = true;
            txtLastName.Visible = true;

            label4.Hide();
            txtReleaseYear.Hide();

            label5.Visible = true;
            txtId.Visible = true;

            //Console.WriteLine("1. All authors");
            //Console.WriteLine("2. Add new author");
            //Console.WriteLine("3. Update");
            //Console.WriteLine("4. Fetch author by ID");
            //Console.WriteLine("5. Delete author by ID");
            //Console.WriteLine("6. Exit");


            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries.");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Exit");
        }

        private void ClearTextBoxes()
        {
            txtBirthYear.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtReleaseYear.Text = "0";
            txtId.Text = "0";
        }

        private void UpdateGridAuthor()
        {
            dataGridView1.DataSource = authorBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AuthorShow()
        {
            UpdateGridAuthor();
            ClearTextBoxes();
            
        }

        private void FetchAuthor()
        {
            int id = int.Parse(txtId.Text);
            dataGridView1.DataSource = new List<Author> { authorBusiness.Get(id) };
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ClearTextBoxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if(comboBox1.SelectedIndex == 0)
                    AuthorShow();
                else if (comboBox1.SelectedIndex == 1)
                    FetchAuthor();
            }
        }
    }
}
