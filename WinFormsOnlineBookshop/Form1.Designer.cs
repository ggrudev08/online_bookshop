namespace WinFormsOnlineBookshop
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
            HeadingLabel = new Label();
            btnInsert = new Button();
            comboBox1 = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBirthYear = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtReleaseYear = new TextBox();
            txtId = new TextBox();
            dataGridView1 = new DataGridView();
            btnAuthor = new Button();
            btnBook = new Button();
            btnCustomer = new Button();
            btnOrder = new Button();
            btnExit = new Button();
            label7 = new Label();
            txtTitle = new TextBox();
            label8 = new Label();
            txtGenre = new TextBox();
            label9 = new Label();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.BackColor = SystemColors.ActiveCaption;
            HeadingLabel.Font = new Font("Magneto", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HeadingLabel.ForeColor = SystemColors.ControlText;
            HeadingLabel.ImageAlign = ContentAlignment.TopRight;
            HeadingLabel.Location = new Point(371, 26);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(576, 73);
            HeadingLabel.TabIndex = 0;
            HeadingLabel.Text = "Online Bookshop";
            HeadingLabel.TextAlign = ContentAlignment.MiddleLeft;
            HeadingLabel.Click += label1_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.GradientActiveCaption;
            btnInsert.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(470, 543);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(113, 42);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.GradientActiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 122);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(659, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(712, 543);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(587, 543);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(32, 120);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 5;
            label1.Text = "Birth year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(32, 164);
            label2.Name = "label2";
            label2.Size = new Size(116, 29);
            label2.TabIndex = 6;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(32, 204);
            label3.Name = "label3";
            label3.Size = new Size(112, 29);
            label3.TabIndex = 7;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(32, 244);
            label4.Name = "label4";
            label4.Size = new Size(139, 29);
            label4.TabIndex = 8;
            label4.Text = "Release year";
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 22);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 290);
            label6.Name = "label6";
            label6.Size = new Size(32, 29);
            label6.TabIndex = 10;
            label6.Text = "Id";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBirthYear
            // 
            txtBirthYear.BackColor = SystemColors.GradientActiveCaption;
            txtBirthYear.Location = new Point(169, 120);
            txtBirthYear.Margin = new Padding(3, 2, 3, 2);
            txtBirthYear.Name = "txtBirthYear";
            txtBirthYear.Size = new Size(125, 27);
            txtBirthYear.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.GradientActiveCaption;
            txtFirstName.Location = new Point(169, 164);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.GradientActiveCaption;
            txtLastName.Location = new Point(169, 210);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 14;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.BackColor = SystemColors.GradientActiveCaption;
            txtReleaseYear.Location = new Point(169, 250);
            txtReleaseYear.Margin = new Padding(3, 2, 3, 2);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(125, 27);
            txtReleaseYear.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Location = new Point(169, 290);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 178);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(661, 338);
            dataGridView1.TabIndex = 17;
            // 
            // btnAuthor
            // 
            btnAuthor.BackColor = SystemColors.GradientActiveCaption;
            btnAuthor.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnAuthor.Location = new Point(15, 487);
            btnAuthor.Margin = new Padding(3, 4, 3, 4);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(136, 46);
            btnAuthor.TabIndex = 18;
            btnAuthor.Text = "Author";
            btnAuthor.UseVisualStyleBackColor = false;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.GradientActiveCaption;
            btnBook.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnBook.Location = new Point(154, 539);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(126, 48);
            btnBook.TabIndex = 19;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.GradientActiveCaption;
            btnCustomer.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(15, 539);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(136, 48);
            btnCustomer.TabIndex = 20;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.GradientActiveCaption;
            btnOrder.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(154, 487);
            btnOrder.Margin = new Padding(3, 4, 3, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(126, 46);
            btnOrder.TabIndex = 21;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.UseWaitCursor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(836, 543);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 40);
            btnExit.TabIndex = 22;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 14.25F, FontStyle.Italic);
            label7.Location = new Point(32, 333);
            label7.Name = "label7";
            label7.Size = new Size(55, 29);
            label7.TabIndex = 23;
            label7.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.GradientActiveCaption;
            txtTitle.Location = new Point(169, 333);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 14.25F, FontStyle.Italic);
            label8.Location = new Point(32, 375);
            label8.Name = "label8";
            label8.Size = new Size(72, 29);
            label8.TabIndex = 25;
            label8.Text = "Genre";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(169, 380);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(125, 27);
            txtGenre.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 14.25F, FontStyle.Italic);
            label9.Location = new Point(32, 418);
            label9.Name = "label9";
            label9.Size = new Size(64, 29);
            label9.TabIndex = 0;
            label9.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(164, 423);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(130, 27);
            txtPrice.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(986, 606);
            Controls.Add(txtPrice);
            Controls.Add(label9);
            Controls.Add(txtGenre);
            Controls.Add(label8);
            Controls.Add(txtTitle);
            Controls.Add(label7);
            Controls.Add(btnExit);
            Controls.Add(btnOrder);
            Controls.Add(btnCustomer);
            Controls.Add(btnBook);
            Controls.Add(btnAuthor);
            Controls.Add(dataGridView1);
            Controls.Add(txtId);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtBirthYear);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(comboBox1);
            Controls.Add(btnInsert);
            Controls.Add(HeadingLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeadingLabel;
        private Button btnInsert;
        private ComboBox comboBox1;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBirthYear;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtReleaseYear;
        private TextBox txtId;
        private DataGridView dataGridView1;
        private Button btnAuthor;
        private Button btnBook;
        private Button btnCustomer;
        private Button btnOrder;
        private Button btnExit;
        private Label label7;
        private TextBox txtTitle;
        private Label label8;
        private TextBox txtGenre;
        private Label label9;
        private TextBox txtPrice;
    }
}
