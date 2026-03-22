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
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
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
            HeadingLabel.Location = new Point(371, 27);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(576, 73);
            HeadingLabel.TabIndex = 0;
            HeadingLabel.Text = "Online Bookshop";
            HeadingLabel.TextAlign = ContentAlignment.MiddleLeft;
            HeadingLabel.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(313, 536);
            button1.Name = "button1";
            button1.Size = new Size(110, 41);
            button1.TabIndex = 1;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.GradientActiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(659, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(555, 536);
            button2.Name = "button2";
            button2.Size = new Size(118, 40);
            button2.TabIndex = 3;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(430, 536);
            button3.Name = "button3";
            button3.Size = new Size(119, 40);
            button3.TabIndex = 4;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
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
            label5.Size = new Size(101, 23);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 289);
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
            txtBirthYear.Name = "txtBirthYear";
            txtBirthYear.Size = new Size(125, 27);
            txtBirthYear.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.GradientActiveCaption;
            txtFirstName.Location = new Point(169, 164);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.GradientActiveCaption;
            txtLastName.Location = new Point(169, 209);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 14;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.BackColor = SystemColors.GradientActiveCaption;
            txtReleaseYear.Location = new Point(169, 249);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(125, 27);
            txtReleaseYear.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Location = new Point(169, 289);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(661, 339);
            dataGridView1.TabIndex = 17;
            // 
            // btnAuthor
            // 
            btnAuthor.BackColor = SystemColors.GradientActiveCaption;
            btnAuthor.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnAuthor.Location = new Point(30, 357);
            btnAuthor.Margin = new Padding(3, 4, 3, 4);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(133, 45);
            btnAuthor.TabIndex = 18;
            btnAuthor.Text = "Author";
            btnAuthor.UseVisualStyleBackColor = false;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.GradientActiveCaption;
            btnBook.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnBook.Location = new Point(169, 411);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(123, 48);
            btnBook.TabIndex = 19;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.GradientActiveCaption;
            btnCustomer.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(30, 411);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(133, 48);
            btnCustomer.TabIndex = 20;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.GradientActiveCaption;
            btnOrder.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(169, 357);
            btnOrder.Margin = new Padding(3, 4, 3, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(123, 45);
            btnOrder.TabIndex = 21;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.UseWaitCursor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(679, 536);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 40);
            btnExit.TabIndex = 22;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(986, 605);
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
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(HeadingLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeadingLabel;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
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
    }
}
