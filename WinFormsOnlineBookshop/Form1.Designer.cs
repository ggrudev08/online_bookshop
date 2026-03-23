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
            HeadingLabel.Location = new Point(325, 20);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(462, 58);
            HeadingLabel.TabIndex = 0;
            HeadingLabel.Text = "Online Bookshop";
            HeadingLabel.TextAlign = ContentAlignment.MiddleLeft;
            HeadingLabel.Click += label1_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.GradientActiveCaption;
            btnInsert.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(274, 402);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(96, 31);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.GradientActiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(273, 91);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(577, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(486, 402);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 30);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(376, 402);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 30);
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
            label1.Location = new Point(28, 90);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 5;
            label1.Text = "Birth year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(28, 123);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 6;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(28, 153);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 7;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(28, 183);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 8;
            label4.Text = "Release year";
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 17);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 217);
            label6.Name = "label6";
            label6.Size = new Size(25, 23);
            label6.TabIndex = 10;
            label6.Text = "Id";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBirthYear
            // 
            txtBirthYear.BackColor = SystemColors.GradientActiveCaption;
            txtBirthYear.Location = new Point(148, 90);
            txtBirthYear.Margin = new Padding(3, 2, 3, 2);
            txtBirthYear.Name = "txtBirthYear";
            txtBirthYear.Size = new Size(110, 23);
            txtBirthYear.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.GradientActiveCaption;
            txtFirstName.Location = new Point(148, 123);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(110, 23);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.GradientActiveCaption;
            txtLastName.Location = new Point(148, 157);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(110, 23);
            txtLastName.TabIndex = 14;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.BackColor = SystemColors.GradientActiveCaption;
            txtReleaseYear.Location = new Point(148, 187);
            txtReleaseYear.Margin = new Padding(3, 2, 3, 2);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(110, 23);
            txtReleaseYear.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Location = new Point(148, 217);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(273, 134);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(578, 254);
            dataGridView1.TabIndex = 17;
            // 
            // btnAuthor
            // 
            btnAuthor.BackColor = SystemColors.GradientActiveCaption;
            btnAuthor.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnAuthor.Location = new Point(26, 268);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(116, 34);
            btnAuthor.TabIndex = 18;
            btnAuthor.Text = "Author";
            btnAuthor.UseVisualStyleBackColor = false;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.GradientActiveCaption;
            btnBook.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnBook.Location = new Point(148, 308);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(108, 36);
            btnBook.TabIndex = 19;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.GradientActiveCaption;
            btnCustomer.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(26, 308);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(116, 36);
            btnCustomer.TabIndex = 20;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.GradientActiveCaption;
            btnOrder.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(148, 268);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(108, 34);
            btnOrder.TabIndex = 21;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.UseWaitCursor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(594, 402);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 30);
            btnExit.TabIndex = 22;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(863, 454);
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
    }
}
