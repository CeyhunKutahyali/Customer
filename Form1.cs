using System.Data;
using System.Data.SqlClient;

namespace Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                string query = "SELECT * FROM Customer WHERE Deleted = 0";
                SqlDataAdapter da = new SqlDataAdapter(query, ConnectionString.connection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müþteri Bilgileri Alýnýrken Bir Hata Oluþtu." + ex.Message);
            }
            finally
            {
                if (ConnectionString.connection != null)
                {
                    ConnectionString.connection().Close();
                }
            }
            dataGridView1.ClearSelection();
        }

        private void CustomerInformationClear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtMonthlyIncome.Text = "";
            checkBox1.Checked = false;
            richTextBox1.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            if (selectedRow != -1)
            {
                txtId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
                txtSurname.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
                txtMonthlyIncome.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
                bool cellValue = Convert.ToBoolean(dataGridView1.Rows[selectedRow].Cells[4].Value);
                checkBox1.Checked = cellValue;
                richTextBox1.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Customer (CustomerName, CustomerSurname, MonthlyIncome, CustomerAddress, CreditAvailable) VALUES (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand command = new SqlCommand(query, ConnectionString.connection());
                command.Parameters.AddWithValue("@p1", txtName.Text);
                command.Parameters.AddWithValue("@p2", txtSurname.Text);
                command.Parameters.AddWithValue("@p3", txtMonthlyIncome.Text);
                command.Parameters.AddWithValue("@p4", richTextBox1.Text);
                if (Convert.ToInt32(txtMonthlyIncome.Text) >= 10000)
                {
                    command.Parameters.AddWithValue("@p5", true);
                }
                else
                {
                    command.Parameters.AddWithValue("@p5", false);
                }

                command.ExecuteNonQuery();

                MessageBox.Show("Müþteri Kayýt Ýþlemi Baþarýlý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müþteri Kayýt Ýþlemi Sýrasýnda Bir Hata Oluþtu." + ex.Message);
            }
            finally
            {
                if (ConnectionString.connection != null)
                {
                    ConnectionString.connection().Close();
                }
            }
            ShowData();
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Customer SET CustomerName = @p1, CustomerSurname = @p2, MonthlyIncome = @p3, CreditAvailable = @p4, CustomerAddress = @p5 WHERE CustomerId = @p6";
                SqlCommand command = new SqlCommand(query, ConnectionString.connection());
                command.Parameters.AddWithValue("@p1", txtName.Text);
                command.Parameters.AddWithValue("@p2", txtSurname.Text);
                command.Parameters.AddWithValue("@p3", txtMonthlyIncome.Text);
                command.Parameters.AddWithValue("@p4", checkBox1.Checked);
                command.Parameters.AddWithValue("@p5", richTextBox1.Text);
                command.Parameters.AddWithValue("@p6", txtId.Text);
                if (Convert.ToInt32(txtMonthlyIncome.Text) <= 10000 && checkBox1.Checked == true)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("Aylýk Gelir Yeterli Olmadýðýndan Krediye Uygunluk Verilemedi");
                }
                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Müþteri Güncelleme Ýþlemi Baþarýlý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Müþteri Bilgileri Güncellenirken Bir Hata Oluþtu" + ex.Message);
            }
            finally
            {
                if (ConnectionString.connection != null)
                {
                    ConnectionString.connection().Close();
                }
                ShowData();
                CustomerInformationClear();
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Customer SET Deleted = 1 WHERE CustomerId = @p1";
                SqlCommand command = new SqlCommand(query, ConnectionString.connection());
                
                command.Parameters.AddWithValue("@p1", txtId.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Müþteri Silme Ýþlemi Baþarýlý.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müþteri Silme Ýþlemi Sýrasýnda Bir Hata Oluþtu" + ex.Message);
            }
            finally
            {
                if (ConnectionString.connection != null)
                {
                    ConnectionString.connection().Close();
                }
                ShowData();
                CustomerInformationClear();
            }
        }
    }
}