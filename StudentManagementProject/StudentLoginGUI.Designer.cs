namespace StudentManagementGUI
{
    partial class StudentLoginGUI
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
            btn_show = new Button();
            SuspendLayout();
            // 
            // btn_show
            // 
            btn_show.Location = new Point(499, 329);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(150, 46);
            btn_show.TabIndex = 0;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // StudentLoginGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 560);
            Controls.Add(btn_show);
            Name = "StudentLoginGUI";
            Text = "StudentLoginGUI";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_show;
    }
}