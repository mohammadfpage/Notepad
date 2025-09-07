using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("لطفاً نام کاربری و رمز عبور را وارد کنید");
                return;
            }

            string connectionString = "Data Source=.\\SQL2022;Initial Catalog=Notepad;User ID=sa;Password=MDev2025!!;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // بررسی وجود نام کاربری
                    string checkQuery = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    int userCount = (int)checkCmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("این نام کاربری قبلاً ثبت شده است. لطفاً نام کاربری دیگری انتخاب کنید.");
                        return;
                    }

                    // ثبت‌نام کاربر جدید
                    string insertQuery = $"INSERT INTO Users (Username, Password) VALUES ('{username}', '{password}')";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    int rows = insertCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("ثبت‌نام با موفقیت انجام شد");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ثبت‌نام با خطا مواجه شد");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا: " + ex.Message);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

        }
    }
}
