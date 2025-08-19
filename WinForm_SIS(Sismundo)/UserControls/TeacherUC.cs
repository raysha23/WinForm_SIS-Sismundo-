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

namespace WinForm_SIS_Sismundo_.UserControls
{
    public partial class TeacherUC : UserControl
    {
        public TeacherUC()
        {
            InitializeComponent();
        }

        private void TeacherUC_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = "Select * From Teacher order by teacher_id desc";
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind to DataGridView
                    GridViewTeachers.DataSource = dt;
                }
            }
        }
    }
}
