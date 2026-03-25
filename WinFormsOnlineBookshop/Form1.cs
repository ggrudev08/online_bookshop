using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;

namespace WinFormsOnlineBookshop
{
    public partial class Form1 : Form
    {
        private AuthorBusiness _authorBusiness = new AuthorBusiness();
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
            switch (flag)
            {
                case 1:
                    InsertAuthor();
                    AuthorShow();
                    break;
                case 3:
                    InsertCustomer();
                    CustomerShow();
                    break;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    DeleteAuthor();
                    AuthorShow();
                    break;
                case 3: 
                    DeleteCustomer();
                    CustomerShow();
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    UpdateAuthor();
                    AuthorShow();
                    break;
                case 3:
                    UpdateCustomer();
                    CustomerShow();
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetVisibility()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            txtBirthYear.Visible = true;
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtReleaseYear.Visible = true;
            txtId.Visible = true;
        }

        private void ClearTextBoxes()
        {
            txtBirthYear.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtReleaseYear.Text = "";
            txtId.Text = "";
        }

        // ----------------- Author Logic -----------------
        private void btnAuthor_Click(object sender, EventArgs e)
        {
            flag = 1;
            ClearTextBoxes();
            ResetVisibility();

            label4.Hide();
            txtReleaseYear.Hide();

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

        private void InsertAuthor()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int birthYear = int.Parse(txtBirthYear.Text);

            Author author = new Author();
            author.FirstName = firstName;
            author.LastName = lastName;
            author.BirthYear = birthYear;

            _authorBusiness.Add(author);
        }

        private void DeleteAuthor()
        {
            int id = int.Parse(txtId.Text);
            _authorBusiness.Delete(id);
        }

        private void UpdateAuthor()
        {
            int id = int.Parse(txtId.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int birthYear = int.Parse(txtBirthYear.Text);

            var author = _authorBusiness.Get(id);
            author.FirstName = firstName;
            author.LastName = lastName;
            author.BirthYear = birthYear;

            _authorBusiness.Update(author);

        }

        private void UpdateGridAuthor()
        {
            dataGridView1.DataSource = _authorBusiness.GetAll();
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
            dataGridView1.DataSource = new List<Author> { _authorBusiness.Get(id) };
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ClearTextBoxes();
        }


        // ----------------- Author Logic -----------------



        // ----------------- Book Logic -----------------//Недовършено

        private void btnBook_Click(object sender, EventArgs e)
        {
            flag = 2;
            ClearTextBoxes();

            label1.Hide();
            txtBirthYear.Hide();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries.");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Exit");
        }

        private void UpdateGridBook()
        {
            dataGridView1.DataSource = bookBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void BookShow()
        {
            UpdateGridBook();
            ClearTextBoxes();
        }

        private void FetchBook()
        {
            int id = int.Parse(txtId.Text);
            dataGridView1.DataSource = new List<Book> { bookBusiness.Get(id) };
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ClearTextBoxes();
        }

        // ----------------- Book Logic -----------------//Недовършено



        // ----------------- Customer Logic -----------------

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            flag = 3;
            ClearTextBoxes();
            ResetVisibility();

            label4.Hide();
            txtReleaseYear.Hide();
            label1.Hide();
            txtBirthYear.Hide();
            
            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries.");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Exit");

        }

        private void InsertCustomer()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            
            Customer customer = new Customer();
            customer.FirstName = firstName;
            customer.LastName = lastName;

            customerBusiness.Add(customer);
        }
        private void DeleteCustomer()
        {
            int id =int.Parse(txtId.Text);
            customerBusiness.Delete(id);
        }
        private void UpdateCustomer()
        {
            int id = int.Parse(txtId.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            
            var customer = customerBusiness.Get(id);
            customer.FirstName = firstName;
            customer.LastName = lastName;

            customerBusiness.Update(customer);
        }

        public void UpdateGridCustomer()
        {
            dataGridView1.DataSource = customerBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void CustomerShow()
        {
            
            UpdateGridCustomer();
            ClearTextBoxes();
        
        }

        private void FetchCustomer()
        {
            int id = int.Parse(txtId.Text);
            
            dataGridView1.DataSource = new List<Customer> { customerBusiness.Get(id) };
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ClearTextBoxes();
        }

        // ----------------- Customer Logic -----------------

        
        
        // ----------------- Order Logic -----------------//Недовършеноа

        private void btnOrder_Click(object sender, EventArgs e)
        {
            flag = 4;
            ClearTextBoxes();
            ResetVisibility();

            label1.Hide();
            txtBirthYear.Hide();
            label2.Hide();
            txtFirstName.Hide();
            label3.Hide();
            txtLastName.Hide();
            label4.Hide();
            txtReleaseYear.Hide();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("List all entries.");
            comboBox1.Items.Add("Fetch entry by ID");
            comboBox1.Items.Add("Exit");
        }
      


        public void OrderShow()
        {
            UpdateGridOrder();
            ClearTextBoxes();
        }

        public void UpdateGridOrder()
        {
            dataGridView1.DataSource = orderBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        // ----------------- Order Logic -----------------//Недовършено
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (comboBox1.SelectedIndex == 0)
                    AuthorShow();
                else if (comboBox1.SelectedIndex == 1)
                    FetchAuthor();
                else if (comboBox1.SelectedIndex == 2)
                {
                    flag = -1;
                    ResetVisibility();
                    ClearTextBoxes();
                }
            }
            else if (flag == 2)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        BookShow();
                        break;
                    case 1:
                        FetchBook();
                        break;
                    case 2:
                        flag = -1;
                        ResetVisibility();
                        ClearTextBoxes();
                        break;
                }
            }
            else if (flag == 3)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        CustomerShow();
                        break;
                    case 1:
                        FetchCustomer();
                        break;
                    case 2:
                        flag = -1;
                        ResetVisibility();
                        ClearTextBoxes();
                        break;
                }
            }
            else if (flag == 4)
            {
            


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
