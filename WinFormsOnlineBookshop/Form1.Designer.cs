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
            HeadingLabel.Location = new Point(264, 25);
            HeadingLabel.Margin = new Padding(4, 0, 4, 0);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(691, 86);
            HeadingLabel.TabIndex = 0;
            HeadingLabel.Text = "Online Bookshop";
            HeadingLabel.TextAlign = ContentAlignment.MiddleLeft;
            HeadingLabel.Click += label1_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.GradientActiveCaption;
            btnInsert.Font = new Font("Impact", 13F, FontStyle.Italic);
            btnInsert.Location = new Point(696, 624);
            btnInsert.Margin = new Padding(4, 2, 4, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(141, 52);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.GradientActiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 126);
            comboBox1.Margin = new Padding(4, 2, 4, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(1271, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Font = new Font("Impact", 13F, FontStyle.Italic);
            btnUpdate.Location = new Point(994, 624);
            btnUpdate.Margin = new Padding(4, 2, 4, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(141, 52);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Impact", 13F, FontStyle.Italic);
            btnDelete.Location = new Point(845, 624);
            btnDelete.Margin = new Padding(4, 2, 4, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 52);
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
            label1.Location = new Point(48, 211);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 36);
            label1.TabIndex = 5;
            label1.Text = "Birth year";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(48, 255);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 36);
            label2.TabIndex = 6;
            label2.Text = "First name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(48, 299);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 36);
            label3.TabIndex = 7;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(48, 338);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 36);
            label4.TabIndex = 8;
            label4.Text = "Release year";
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 387);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 36);
            label6.TabIndex = 10;
            label6.Text = "Id";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBirthYear
            // 
            txtBirthYear.BackColor = SystemColors.GradientActiveCaption;
            txtBirthYear.Location = new Point(223, 216);
            txtBirthYear.Margin = new Padding(4, 2, 4, 2);
            txtBirthYear.Name = "txtBirthYear";
            txtBirthYear.Size = new Size(155, 31);
            txtBirthYear.TabIndex = 12;
            txtBirthYear.TextChanged += txtBirthYear_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.GradientActiveCaption;
            txtFirstName.Location = new Point(223, 260);
            txtFirstName.Margin = new Padding(4, 2, 4, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(155, 31);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.GradientActiveCaption;
            txtLastName.Location = new Point(223, 304);
            txtLastName.Margin = new Padding(4, 2, 4, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(155, 31);
            txtLastName.TabIndex = 14;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.BackColor = SystemColors.GradientActiveCaption;
            txtReleaseYear.Location = new Point(224, 348);
            txtReleaseYear.Margin = new Padding(4, 2, 4, 2);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(154, 31);
            txtReleaseYear.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Location = new Point(223, 392);
            txtId.Margin = new Padding(4, 2, 4, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(155, 31);
            txtId.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(426, 178);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 422);
            dataGridView1.TabIndex = 17;
            // 
            // btnAuthor
            // 
            btnAuthor.BackColor = SystemColors.GradientActiveCaption;
            btnAuthor.Font = new Font("Impact", 13F, FontStyle.Italic);
            btnAuthor.Location = new Point(48, 624);
            btnAuthor.Margin = new Padding(4, 5, 4, 5);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(141, 52);
            btnAuthor.TabIndex = 18;
            btnAuthor.Text = "AUTHOR";
            btnAuthor.UseVisualStyleBackColor = false;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.GradientActiveCaption;
            btnBook.Font = new Font("Impact", 13F, FontStyle.Italic);
            btnBook.Location = new Point(495, 624);
            btnBook.Margin = new Padding(4, 5, 4, 5);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(141, 52);
            btnBook.TabIndex = 19;
            btnBook.Text = "BOOK";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = SystemColors.GradientActiveCaption;
            btnCustomer.Font = new Font("Impact", 13F, FontStyle.Italic);
            btnCustomer.Location = new Point(346, 624);
            btnCustomer.Margin = new Padding(4, 5, 4, 5);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(141, 52);
            btnCustomer.TabIndex = 20;
            btnCustomer.Text = "CUSTOMER";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.GradientActiveCaption;
            btnOrder.Font = new Font("Impact", 13F, FontStyle.Italic);
            btnOrder.Location = new Point(197, 624);
            btnOrder.Margin = new Padding(4, 5, 4, 5);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(141, 52);
            btnOrder.TabIndex = 21;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.UseWaitCursor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.Font = new Font("Impact", 13F, FontStyle.Italic);
            btnExit.Location = new Point(1143, 624);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 52);
            btnExit.TabIndex = 22;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 14.25F, FontStyle.Italic);
            label7.Location = new Point(48, 431);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 36);
            label7.TabIndex = 23;
            label7.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.GradientActiveCaption;
            txtTitle.Location = new Point(223, 524);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(155, 31);
            txtTitle.TabIndex = 24;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 14.25F, FontStyle.Italic);
            label8.Location = new Point(48, 475);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 36);
            label8.TabIndex = 25;
            label8.Text = "Genre";
            // 
            // txtGenre
            // 
            txtGenre.BackColor = SystemColors.GradientActiveCaption;
            txtGenre.Location = new Point(223, 480);
            txtGenre.Margin = new Padding(4);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(155, 31);
            txtGenre.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 14.25F, FontStyle.Italic);
            label9.Location = new Point(48, 519);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 36);
            label9.TabIndex = 0;
            label9.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.GradientActiveCaption;
            txtPrice.Location = new Point(223, 436);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(155, 31);
            txtPrice.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1297, 715);
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
            Margin = new Padding(4, 2, 4, 2);
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
