
namespace ProgramMain
{
    partial class student_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_main));
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_classhour = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.btn_ask = new System.Windows.Forms.Button();
            this.btn_absent = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_presenttime = new System.Windows.Forms.Label();
            this.nfiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_reset = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.lbl_period = new System.Windows.Forms.Label();
            this.pan01 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pan02 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmsMenu.SuspendLayout();
            this.pan01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan02.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_day.ForeColor = System.Drawing.Color.White;
            this.lbl_day.Location = new System.Drawing.Point(285, 19);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(50, 17);
            this.lbl_day.TabIndex = 2;
            this.lbl_day.Text = "수요일";
            this.lbl_day.Click += new System.EventHandler(this.lbl_day_Click);
            // 
            // lbl_classhour
            // 
            this.lbl_classhour.AutoSize = true;
            this.lbl_classhour.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_classhour.ForeColor = System.Drawing.Color.White;
            this.lbl_classhour.Location = new System.Drawing.Point(304, 35);
            this.lbl_classhour.Name = "lbl_classhour";
            this.lbl_classhour.Size = new System.Drawing.Size(87, 17);
            this.lbl_classhour.TabIndex = 3;
            this.lbl_classhour.Text = "14:00~16:50";
            this.lbl_classhour.Click += new System.EventHandler(this.lbl_classhour_Click);
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_subject.ForeColor = System.Drawing.Color.White;
            this.lbl_subject.Location = new System.Drawing.Point(35, 15);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(166, 32);
            this.lbl_subject.TabIndex = 5;
            this.lbl_subject.Text = "캡스톤 디자인";
            // 
            // btn_ask
            // 
            this.btn_ask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(61)))));
            this.btn_ask.FlatAppearance.BorderSize = 0;
            this.btn_ask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ask.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ask.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ask.Location = new System.Drawing.Point(182, 90);
            this.btn_ask.Name = "btn_ask";
            this.btn_ask.Size = new System.Drawing.Size(147, 62);
            this.btn_ask.TabIndex = 9;
            this.btn_ask.Text = "질 문";
            this.btn_ask.UseVisualStyleBackColor = false;
            this.btn_ask.Click += new System.EventHandler(this.btn_ask_Click);
            // 
            // btn_absent
            // 
            this.btn_absent.BackColor = System.Drawing.Color.Silver;
            this.btn_absent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_absent.FlatAppearance.BorderSize = 0;
            this.btn_absent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_absent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_absent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_absent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_absent.ForeColor = System.Drawing.Color.White;
            this.btn_absent.Location = new System.Drawing.Point(182, 184);
            this.btn_absent.Name = "btn_absent";
            this.btn_absent.Size = new System.Drawing.Size(147, 61);
            this.btn_absent.TabIndex = 11;
            this.btn_absent.Text = "출 석";
            this.btn_absent.UseVisualStyleBackColor = false;
            this.btn_absent.Click += new System.EventHandler(this.btn_absent_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_name.Location = new System.Drawing.Point(36, 44);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 17);
            this.lbl_name.TabIndex = 15;
            this.lbl_name.Text = "홍길동";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(355, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "시간표";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_presenttime
            // 
            this.lbl_presenttime.AutoSize = true;
            this.lbl_presenttime.Location = new System.Drawing.Point(786, 308);
            this.lbl_presenttime.Name = "lbl_presenttime";
            this.lbl_presenttime.Size = new System.Drawing.Size(0, 17);
            this.lbl_presenttime.TabIndex = 18;
            // 
            // nfiTray
            // 
            this.nfiTray.ContextMenuStrip = this.cmsMenu;
            this.nfiTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nfiTray.Icon")));
            this.nfiTray.Text = "유한대학교 비대면시스템";
            this.nfiTray.Visible = true;
            this.nfiTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfiTray_MouseDoubleClick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(99, 26);
            this.cmsMenu.UseWaitCursor = true;
            this.cmsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMenu_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem1.Text = "열기";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(355, 124);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(133, 37);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.Text = "새로고침";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // lbl_period
            // 
            this.lbl_period.AutoSize = true;
            this.lbl_period.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_period.ForeColor = System.Drawing.Color.White;
            this.lbl_period.Location = new System.Drawing.Point(338, 19);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(69, 17);
            this.lbl_period.TabIndex = 25;
            this.lbl_period.Text = "(5~6교시)";
            this.lbl_period.Click += new System.EventHandler(this.lbl_period_Click);
            // 
            // pan01
            // 
            this.pan01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.pan01.Controls.Add(this.pictureBox1);
            this.pan01.Controls.Add(this.lblNo);
            this.pan01.Controls.Add(this.panel2);
            this.pan01.Controls.Add(this.lbl_name);
            this.pan01.ForeColor = System.Drawing.Color.Black;
            this.pan01.Location = new System.Drawing.Point(0, 0);
            this.pan01.Name = "pan01";
            this.pan01.Size = new System.Drawing.Size(122, 265);
            this.pan01.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramMain.Properties.Resources.img_sbmark_large;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNo.ForeColor = System.Drawing.Color.Transparent;
            this.lblNo.Location = new System.Drawing.Point(14, 16);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(91, 21);
            this.lblNo.TabIndex = 27;
            this.lblNo.Text = "201827068";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(125, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 113);
            this.panel2.TabIndex = 0;
            // 
            // pan02
            // 
            this.pan02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(61)))));
            this.pan02.Controls.Add(this.lbl_subject);
            this.pan02.Controls.Add(this.lbl_period);
            this.pan02.Controls.Add(this.lbl_day);
            this.pan02.Controls.Add(this.lbl_classhour);
            this.pan02.Location = new System.Drawing.Point(122, 0);
            this.pan02.Name = "pan02";
            this.pan02.Size = new System.Drawing.Size(430, 67);
            this.pan02.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(355, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "로그아웃";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(355, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 37);
            this.button3.TabIndex = 29;
            this.button3.Text = "종료";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // student_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 264);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pan02);
            this.Controls.Add(this.pan01);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_presenttime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_absent);
            this.Controls.Add(this.btn_ask);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "student_main";
            this.Text = "학생";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.student_main_FormClosing);
            this.Load += new System.EventHandler(this.student_main_Load);
            this.VisibleChanged += new System.EventHandler(this.student_main_VisibleChanged);
            this.cmsMenu.ResumeLayout(false);
            this.pan01.ResumeLayout(false);
            this.pan01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan02.ResumeLayout(false);
            this.pan02.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Label lbl_classhour;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Button btn_ask;
        private System.Windows.Forms.Button btn_absent;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_presenttime;
        private System.Windows.Forms.NotifyIcon nfiTray;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label lbl_period;
        private System.Windows.Forms.Panel pan01;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Panel pan02;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

