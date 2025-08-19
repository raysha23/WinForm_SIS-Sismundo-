using System;
using System.Windows.Forms;
using WinForm_SIS_Sismundo_.UserControls;

namespace WinForm_SIS_Sismundo_
{
    public partial class MainForm : Form
    {
        // Declare UserControls
        private DashboardUC ucDashboard;
        private StudentUC ucStudent;
        private TeacherUC ucTeacher;
        private SubjectUC ucSubject;
        private LogsUC ucLogs;
        private ReportsUC ucReports;

        public MainForm()
        {
            InitializeComponent();
        }

        public void UserControlLoad(UserControl uc)
        {
            // Hide all UCs
            foreach (Control control in this.Controls)
            {
                if (control is UserControl)
                    control.Visible = false;
            }

            // Show selected UC
            uc.Visible = true;
            uc.Dock = DockStyle.Right;
            uc.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize all UserControls
            ucDashboard = new DashboardUC();
            ucStudent = new StudentUC();
            ucTeacher = new TeacherUC();
            ucSubject = new SubjectUC();
            ucLogs = new LogsUC();
            ucReports = new ReportsUC();

            // Add them to MainForm
            this.Controls.Add(ucDashboard);
            ucDashboard.Visible = true;
            ucDashboard.Dock = DockStyle.Right;


            this.Controls.Add(ucStudent);
            this.Controls.Add(ucTeacher);
            this.Controls.Add(ucSubject);
            this.Controls.Add(ucLogs);
            this.Controls.Add(ucReports);

            // Hide them initially
            
            ucStudent.Visible = false;
            ucTeacher.Visible = false;
            ucSubject.Visible = false;
            ucLogs.Visible = false;
            ucReports.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UserControlLoad(ucDashboard);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            UserControlLoad(ucStudent);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            UserControlLoad(ucTeacher);
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            UserControlLoad(ucSubject);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            UserControlLoad(ucLogs);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UserControlLoad(ucReports);
        }

    }
}
