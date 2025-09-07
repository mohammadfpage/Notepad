using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            string connectionString = "Data Source=.\\SQL2022;Initial Catalog=Notepad;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $"SELECT COUNT(*) FROM Users WHERE Username='{username}' AND Password='{password}'";

                    SqlCommand cmd = new SqlCommand(query, con);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("ورود موفقیت‌آمیز بود", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMain mainForm = new frmMain();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در اتصال به پایگاه داده: " + ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
            
        }
    }
}
