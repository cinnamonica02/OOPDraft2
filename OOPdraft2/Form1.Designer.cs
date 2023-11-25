namespace $safeprojectname$
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.add_students_btn = new System.Windows.Forms.Button();
            this.show_Students_btn = new System.Windows.Forms.Button();
            this.search_Student_Btn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Data Management";
            // 
            // add_students_btn
            // 
            this.add_students_btn.Location = new System.Drawing.Point(100, 62);
            this.add_students_btn.Name = "add_students_btn";
            this.add_students_btn.Size = new System.Drawing.Size(252, 49);
            this.add_students_btn.TabIndex = 1;
            this.add_students_btn.Text = "Add Students";
            this.add_students_btn.UseVisualStyleBackColor = true;
            this.add_students_btn.Click += new System.EventHandler(this.add_students_btn_Click);
            // 
            // show_Students_btn
            // 
            this.show_Students_btn.Location = new System.Drawing.Point(100, 117);
            this.show_Students_btn.Name = "show_Students_btn";
            this.show_Students_btn.Size = new System.Drawing.Size(252, 49);
            this.show_Students_btn.TabIndex = 2;
            this.show_Students_btn.Text = "Show Students";
            this.show_Students_btn.UseVisualStyleBackColor = true;
            this.show_Students_btn.Click += new System.EventHandler(this.show_Students_btn_Click_1);
            // 
            // search_Student_Btn
            // 
            this.search_Student_Btn.Location = new System.Drawing.Point(100, 172);
            this.search_Student_Btn.Name = "search_Student_Btn";
            this.search_Student_Btn.Size = new System.Drawing.Size(252, 49);
            this.search_Student_Btn.TabIndex = 3;
            this.search_Student_Btn.Text = "Search Student";
            this.search_Student_Btn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(100, 373);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(252, 33);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(388, 418);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.search_Student_Btn);
            this.Controls.Add(this.show_Students_btn);
            this.Controls.Add(this.add_students_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_students_btn;
        private System.Windows.Forms.Button show_Students_btn;
        private System.Windows.Forms.Button search_Student_Btn;
        private System.Windows.Forms.Button exitBtn;
    }
}

