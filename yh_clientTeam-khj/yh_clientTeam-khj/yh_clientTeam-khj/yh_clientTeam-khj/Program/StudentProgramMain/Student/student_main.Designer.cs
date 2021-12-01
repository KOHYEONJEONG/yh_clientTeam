
namespace StudentProgramMain.Student
{
    partial class student_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_period = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.btn_ask = new System.Windows.Forms.Button();
            this.btn_absent = new System.Windows.Forms.Button();
            this.atdTimer = new System.Windows.Forms.Timer(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.nfiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.waterBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.lblNo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 226);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(36, 34);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(31, 15);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "이름";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.btnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(-10, 53);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(135, 46);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "시간표";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(11, 13);
            this.lblNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(42, 21);
            this.lblNo.TabIndex = 5;
            this.lblNo.Text = "학번";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_subject);
            this.panel2.Controls.Add(this.lbl_end);
            this.panel2.Controls.Add(this.lbl_start);
            this.panel2.Controls.Add(this.lbl_period);
            this.panel2.Controls.Add(this.lbl_day);
            this.panel2.Location = new System.Drawing.Point(115, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 54);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "~";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_subject.ForeColor = System.Drawing.Color.White;
            this.lbl_subject.Location = new System.Drawing.Point(12, 12);
            this.lbl_subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(86, 32);
            this.lbl_subject.TabIndex = 5;
            this.lbl_subject.Text = "과목명";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_end.ForeColor = System.Drawing.Color.White;
            this.lbl_end.Location = new System.Drawing.Point(345, 28);
            this.lbl_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(38, 15);
            this.lbl_end.TabIndex = 5;
            this.lbl_end.Text = "11:00";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_start.ForeColor = System.Drawing.Color.White;
            this.lbl_start.Location = new System.Drawing.Point(294, 28);
            this.lbl_start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(38, 15);
            this.lbl_start.TabIndex = 5;
            this.lbl_start.Text = "10:00";
            this.lbl_start.Click += new System.EventHandler(this.lbl_start_Click);
            // 
            // lbl_period
            // 
            this.lbl_period.AutoSize = true;
            this.lbl_period.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_period.ForeColor = System.Drawing.Color.White;
            this.lbl_period.Location = new System.Drawing.Point(307, 12);
            this.lbl_period.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(79, 15);
            this.lbl_period.TabIndex = 5;
            this.lbl_period.Text = "우체국교수님";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_day.ForeColor = System.Drawing.Color.White;
            this.lbl_day.Location = new System.Drawing.Point(268, 12);
            this.lbl_day.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(36, 15);
            this.lbl_day.TabIndex = 5;
            this.lbl_day.Text = "?요일";
            // 
            // btn_ask
            // 
            this.btn_ask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(61)))));
            this.btn_ask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ask.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ask.ForeColor = System.Drawing.Color.White;
            this.btn_ask.Location = new System.Drawing.Point(155, 58);
            this.btn_ask.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ask.Name = "btn_ask";
            this.btn_ask.Size = new System.Drawing.Size(112, 92);
            this.btn_ask.TabIndex = 1;
            this.btn_ask.Text = "질 문";
            this.btn_ask.UseVisualStyleBackColor = false;
            this.btn_ask.Click += new System.EventHandler(this.btn_ask_Click);
            // 
            // btn_absent
            // 
            this.btn_absent.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_absent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_absent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_absent.ForeColor = System.Drawing.Color.White;
            this.btn_absent.Location = new System.Drawing.Point(350, 58);
            this.btn_absent.Margin = new System.Windows.Forms.Padding(2);
            this.btn_absent.Name = "btn_absent";
            this.btn_absent.Size = new System.Drawing.Size(112, 92);
            this.btn_absent.TabIndex = 2;
            this.btn_absent.Text = "출석";
            this.btn_absent.UseVisualStyleBackColor = false;
            this.btn_absent.Click += new System.EventHandler(this.btn_absent_Click);
            // 
            // atdTimer
            // 
            this.atdTimer.Enabled = true;
            this.atdTimer.Interval = 1000;
            this.atdTimer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(99, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem1.Text = "열기";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // nfiTray
            // 
            this.nfiTray.ContextMenuStrip = this.cmsMenu;
            this.nfiTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiTray.Icon")));
            this.nfiTray.Text = "유한대학교 비대면시스템";
            this.nfiTray.Visible = true;
            this.nfiTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfiTray_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(61)))));
            this.button1.Location = new System.Drawing.Point(293, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(61)))));
            this.viewBtn.Enabled = false;
            this.viewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.viewBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(159, 175);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(303, 47);
            this.viewBtn.TabIndex = 4;
            this.viewBtn.Text = "수업 대기중";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // waterBtn
            // 
            this.waterBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.waterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waterBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.waterBtn.Location = new System.Drawing.Point(316, 155);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(11, 37);
            this.waterBtn.TabIndex = 5;
            this.waterBtn.Text = "button3";
            this.waterBtn.UseVisualStyleBackColor = false;
            this.waterBtn.Visible = false;
            this.waterBtn.Click += new System.EventHandler(this.waterBtn_Click);
            // 
            // student_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 224);
            this.Controls.Add(this.waterBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_absent);
            this.Controls.Add(this.btn_ask);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "student_main";
            this.Text = "메인화면";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.student_main_FormClosing);
            this.Load += new System.EventHandler(this.student_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ask;
        private System.Windows.Forms.Button btn_absent;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_period;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Timer atdTimer;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.NotifyIcon nfiTray;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button waterBtn;
        public System.Windows.Forms.Button viewBtn;
    }
}