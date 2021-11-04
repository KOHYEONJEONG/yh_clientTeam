
namespace ProgramMain.Student
{
    partial class student_manager
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_hak = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_classhour = new System.Windows.Forms.Label();
            this.cbb_day = new System.Windows.Forms.ComboBox();
            this.tb_period = new System.Windows.Forms.TextBox();
            this.tb_classhour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "학  번 입력:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "이  름 입력:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "교과목 입력:";
            // 
            // tb_hak
            // 
            this.tb_hak.Location = new System.Drawing.Point(139, 37);
            this.tb_hak.Name = "tb_hak";
            this.tb_hak.Size = new System.Drawing.Size(100, 23);
            this.tb_hak.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(139, 75);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 23);
            this.tb_name.TabIndex = 4;
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(139, 113);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(100, 23);
            this.tb_subject.TabIndex = 5;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(315, 241);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "확 인";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Location = new System.Drawing.Point(42, 154);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(70, 15);
            this.lbl_day.TabIndex = 7;
            this.lbl_day.Text = "요  일 입력:";
            // 
            // lbl_classhour
            // 
            this.lbl_classhour.AutoSize = true;
            this.lbl_classhour.Location = new System.Drawing.Point(42, 192);
            this.lbl_classhour.Name = "lbl_classhour";
            this.lbl_classhour.Size = new System.Drawing.Size(86, 15);
            this.lbl_classhour.TabIndex = 8;
            this.lbl_classhour.Text = "수업시간 입력:";
            // 
            // cbb_day
            // 
            this.cbb_day.FormattingEnabled = true;
            this.cbb_day.Items.AddRange(new object[] {
            "월요일",
            "화요일",
            "수요일",
            "목요일",
            "금요일"});
            this.cbb_day.Location = new System.Drawing.Point(139, 151);
            this.cbb_day.Name = "cbb_day";
            this.cbb_day.Size = new System.Drawing.Size(121, 23);
            this.cbb_day.TabIndex = 9;
            this.cbb_day.SelectedIndexChanged += new System.EventHandler(this.cbb_day_SelectedIndexChanged);
            // 
            // tb_period
            // 
            this.tb_period.Location = new System.Drawing.Point(266, 151);
            this.tb_period.Name = "tb_period";
            this.tb_period.Size = new System.Drawing.Size(72, 23);
            this.tb_period.TabIndex = 11;
            // 
            // tb_classhour
            // 
            this.tb_classhour.Location = new System.Drawing.Point(139, 189);
            this.tb_classhour.Name = "tb_classhour";
            this.tb_classhour.Size = new System.Drawing.Size(100, 23);
            this.tb_classhour.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "교시";
            // 
            // student_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 276);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_classhour);
            this.Controls.Add(this.tb_period);
            this.Controls.Add(this.cbb_day);
            this.Controls.Add(this.lbl_classhour);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_hak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "student_manager";
            this.Text = "student_manager";
            this.Load += new System.EventHandler(this.student_manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_hak;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Label lbl_classhour;
        private System.Windows.Forms.ComboBox cbb_day;
        private System.Windows.Forms.TextBox tb_period;
        private System.Windows.Forms.TextBox tb_classhour;
        private System.Windows.Forms.Label label5;
    }
}