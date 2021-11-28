
namespace ProgramMain
{
    partial class attendanceForm
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
            this.components = new System.ComponentModel.Container();
            this.attendList = new System.Windows.Forms.ListView();
            this.stuNum = new System.Windows.Forms.ColumnHeader();
            this.stuName = new System.Windows.Forms.ColumnHeader();
            this.lbTitle = new System.Windows.Forms.Label();
            this.subjectLb = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // attendList
            // 
            this.attendList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stuNum,
            this.stuName});
            this.attendList.HideSelection = false;
            this.attendList.Location = new System.Drawing.Point(10, 106);
            this.attendList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendList.Name = "attendList";
            this.attendList.Size = new System.Drawing.Size(521, 378);
            this.attendList.TabIndex = 0;
            this.attendList.UseCompatibleStateImageBehavior = false;
            this.attendList.View = System.Windows.Forms.View.Details;
            // 
            // stuNum
            // 
            this.stuNum.Text = "학번";
            this.stuNum.Width = 120;
            // 
            // stuName
            // 
            this.stuName.Text = "이름";
            this.stuName.Width = 95;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("새굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(193, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(134, 27);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "출석 현황";
            // 
            // subjectLb
            // 
            this.subjectLb.AutoSize = true;
            this.subjectLb.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectLb.ForeColor = System.Drawing.Color.White;
            this.subjectLb.Location = new System.Drawing.Point(12, 62);
            this.subjectLb.Name = "subjectLb";
            this.subjectLb.Size = new System.Drawing.Size(41, 16);
            this.subjectLb.TabIndex = 2;
            this.subjectLb.Text = "과목";
            this.subjectLb.Click += new System.EventHandler(this.gradeLb_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(456, 491);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 31);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "닫기";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // attendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(539, 534);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.subjectLb);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.attendList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "attendanceForm";
            this.Text = "attendanceForm";
            this.Load += new System.EventHandler(this.attendanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView attendList;
        private System.Windows.Forms.ColumnHeader stuNum;
        private System.Windows.Forms.ColumnHeader stuName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label subjectLb;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Timer timer;
    }
}