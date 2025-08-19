using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_SIS_Sismundo_.Classes;
using WinForm_SIS_Sismundo_.UserControls;

namespace WinForm_SIS_Sismundo_
{
    public partial class StudentUC : UserControl
    {
        private UserControl addingStudent;
        public StudentUC()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = "Select * From Student order by student_id desc";
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind to DataGridView
                    GridViewStudents.DataSource = dt;
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            
            Form dialogForm = new Form();
            UserControl uc = new AddingStudent();
            uc.Dock = DockStyle.Fill;
            dialogForm.Controls.Add(uc);
            dialogForm.StartPosition = FormStartPosition.CenterParent;
            dialogForm.ShowDialog();

            
        }
    }
}
