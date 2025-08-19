namespace WinForm_SIS_Sismundo_
{
    partial class StudentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GridViewStudents = new DataGridView();
            btnAddStudent = new Button();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // GridViewStudents
            // 
            GridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewStudents.Location = new Point(33, 22);
            GridViewStudents.Name = "GridViewStudents";
            GridViewStudents.ReadOnly = true;
            GridViewStudents.Size = new Size(684, 360);
            GridViewStudents.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(110, 412);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(118, 38);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(315, 412);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(118, 38);
            btnUpdateStudent.TabIndex = 4;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(498, 412);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(118, 38);
            btnDeleteStudent.TabIndex = 5;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // StudentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnUpdateStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(GridViewStudents);
            Name = "StudentUC";
            Size = new Size(756, 478);
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridViewStudents;
        private Button btnAddStudent;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
    }
}
