namespace StudentManagementGUI
{
    partial class CreateStudentGUI
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dtgStudentList = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgStudentList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgStudentList);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1374, 477);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student List";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(22, 495);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1374, 221);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operation";
            // 
            // dtgStudentList
            // 
            dtgStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudentList.Location = new Point(6, 38);
            dtgStudentList.Name = "dtgStudentList";
            dtgStudentList.RowHeadersWidth = 82;
            dtgStudentList.RowTemplate.Height = 41;
            dtgStudentList.Size = new Size(1362, 433);
            dtgStudentList.TabIndex = 0;
            // 
            // CreateStudentGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 746);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CreateStudentGUI";
            Text = "Create Student Form";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgStudentList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtgStudentList;
    }
}