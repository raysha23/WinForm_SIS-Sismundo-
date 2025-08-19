namespace WinForm_SIS_Sismundo_
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDashboard = new Button();
            panel2 = new Panel();
            label1 = new Label();
            btnLogout = new Button();
            btnReports = new Button();
            btnLogs = new Button();
            btnSubject = new Button();
            btnTeacher = new Button();
            btnStudent = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 113);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(115, 38);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(btnLogs);
            panel2.Controls.Add(btnSubject);
            panel2.Controls.Add(btnTeacher);
            panel2.Controls.Add(btnStudent);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(140, 478);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 82);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 8;
            label1.Text = "Welcome!";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 377);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(115, 38);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(12, 333);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(115, 38);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogs
            // 
            btnLogs.Location = new Point(12, 289);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(115, 38);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnSubject
            // 
            btnSubject.Location = new Point(12, 245);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(115, 38);
            btnSubject.TabIndex = 4;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += btnSubject_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.Location = new Point(12, 201);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(115, 38);
            btnTeacher.TabIndex = 3;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(12, 157);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(115, 38);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(896, 478);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDashboard;
        private Panel panel2;
        private Label label1;
        private Button btnLogout;
        private Button btnReports;
        private Button btnLogs;
        private Button btnSubject;
        private Button btnTeacher;
        private Button btnStudent;
    }
}