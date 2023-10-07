namespace StudentManagementGUI
{
    partial class StudentManageGUI
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
            dtg_StudentList = new DataGridView();
            groupBox2 = new GroupBox();
            btn_Exit = new Button();
            btn_Del = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtg_StudentList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_StudentList
            // 
            dtg_StudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_StudentList.Location = new Point(6, 38);
            dtg_StudentList.Name = "dtg_StudentList";
            dtg_StudentList.RowHeadersWidth = 82;
            dtg_StudentList.RowTemplate.Height = 41;
            dtg_StudentList.Size = new Size(1362, 496);
            dtg_StudentList.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Exit);
            groupBox2.Controls.Add(btn_Del);
            groupBox2.Controls.Add(btn_Edit);
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Location = new Point(24, 558);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1374, 182);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operation";
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(1106, 60);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(196, 93);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(759, 60);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(196, 93);
            btn_Del.TabIndex = 2;
            btn_Del.Text = "Delete Student";
            btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(376, 60);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(196, 93);
            btn_Edit.TabIndex = 1;
            btn_Edit.Text = "Edit Student";
            btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(39, 60);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(196, 93);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Add Student";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_StudentList);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1386, 540);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student List";
            // 
            // StudentManageGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 750);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "StudentManageGUI";
            Text = "StudentManageGUI";
            ((System.ComponentModel.ISupportInitialize)dtg_StudentList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_StudentList;
        private GroupBox groupBox2;
        private Button button2;
        private Button btn_Add;
        private GroupBox groupBox1;
        private Button btn_Exit;
        private Button btn_Del;
        private Button btn_Edit;
    }
}