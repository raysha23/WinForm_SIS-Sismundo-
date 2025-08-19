using WinForm_SIS_Sismundo_.Classes;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace WinForm_SIS_Sismundo_
{
    public partial class LoginForn : Form
    {
        static Person p;
        public LoginForn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            //{
            //}
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = "SELECT COUNT(1) FROM User_Login WHERE username = @username AND password_hash = @passwordHash";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@passwordHash", txtPassword.Text);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        new MainForm().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
