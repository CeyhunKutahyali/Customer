namespace Customer
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnGetAllCustomers = new Button();
            btnSearch = new Button();
            btnCustomerDelete = new Button();
            btnCustomerEdit = new Button();
            btnCustomerAdd = new Button();
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMonthlyIncome = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 212);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(829, 212);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btnGetAllCustomers);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnCustomerDelete);
            panel2.Controls.Add(btnCustomerEdit);
            panel2.Controls.Add(btnCustomerAdd);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtMonthlyIncome);
            panel2.Controls.Add(txtSurname);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtId);
            panel2.Location = new Point(12, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 223);
            panel2.TabIndex = 1;
            // 
            // btnGetAllCustomers
            // 
            btnGetAllCustomers.Location = new Point(614, 179);
            btnGetAllCustomers.Name = "btnGetAllCustomers";
            btnGetAllCustomers.Size = new Size(193, 29);
            btnGetAllCustomers.TabIndex = 17;
            btnGetAllCustomers.Text = "Tüm Müşterileri Getir";
            btnGetAllCustomers.UseVisualStyleBackColor = true;
            btnGetAllCustomers.Click += btnGetAllCustomers_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(614, 138);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(193, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Müşteri Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.Location = new Point(614, 96);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(193, 29);
            btnCustomerDelete.TabIndex = 15;
            btnCustomerDelete.Text = "Müşteri Sil";
            btnCustomerDelete.UseVisualStyleBackColor = true;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // btnCustomerEdit
            // 
            btnCustomerEdit.Location = new Point(614, 55);
            btnCustomerEdit.Name = "btnCustomerEdit";
            btnCustomerEdit.Size = new Size(193, 29);
            btnCustomerEdit.TabIndex = 14;
            btnCustomerEdit.Text = "Müşteri Güncelle";
            btnCustomerEdit.UseVisualStyleBackColor = true;
            btnCustomerEdit.Click += btnCustomerEdit_Click;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new Point(614, 14);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(193, 29);
            btnCustomerAdd.TabIndex = 1;
            btnCustomerAdd.Text = "Müşteri Ekle";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(390, 71);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(175, 111);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(390, 30);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 12;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 71);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 11;
            label6.Text = "Adres :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 26);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 10;
            label5.Text = "Kredi Uygunluk :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 158);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Aylık Gelir :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 116);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 71);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 7;
            label2.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 26);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 6;
            label1.Text = "Id :";
            // 
            // txtMonthlyIncome
            // 
            txtMonthlyIncome.Location = new Point(92, 155);
            txtMonthlyIncome.Name = "txtMonthlyIncome";
            txtMonthlyIncome.Size = new Size(153, 27);
            txtMonthlyIncome.TabIndex = 3;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(92, 113);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(153, 27);
            txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(92, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(92, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(153, 27);
            txtId.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(852, 464);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMonthlyIncome;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtId;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
        private Button btnCustomerAdd;
        private Button btnCustomerEdit;
        private Button btnCustomerDelete;
        private Button btnSearch;
        private Button btnGetAllCustomers;
    }
}