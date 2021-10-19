
namespace ProgramMain
{
    partial class StudentOX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentOX));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pn_yes = new System.Windows.Forms.Panel();
            this.pn_no = new System.Windows.Forms.Panel();
            this.lbl_lefttime = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Q. 저번 주차에서 학습한 내용이 기억나시나요?\r\n";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "answer_O_on .png");
            this.imageList1.Images.SetKeyName(1, "answer_O_off.png");
            // 
            // pn_yes
            // 
            this.pn_yes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_yes.BackgroundImage")));
            this.pn_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pn_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_yes.Location = new System.Drawing.Point(56, 137);
            this.pn_yes.Name = "pn_yes";
            this.pn_yes.Size = new System.Drawing.Size(209, 193);
            this.pn_yes.TabIndex = 3;
            this.pn_yes.Click += new System.EventHandler(this.pn_yes_Click);
            // 
            // pn_no
            // 
            this.pn_no.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_no.BackgroundImage")));
            this.pn_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pn_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_no.Location = new System.Drawing.Point(294, 137);
            this.pn_no.Name = "pn_no";
            this.pn_no.Size = new System.Drawing.Size(209, 193);
            this.pn_no.TabIndex = 4;
            this.pn_no.Click += new System.EventHandler(this.pn_no_Click);
            // 
            // lbl_lefttime
            // 
            this.lbl_lefttime.AutoSize = true;
            this.lbl_lefttime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_lefttime.ForeColor = System.Drawing.Color.Red;
            this.lbl_lefttime.Location = new System.Drawing.Point(13, 13);
            this.lbl_lefttime.Name = "lbl_lefttime";
            this.lbl_lefttime.Size = new System.Drawing.Size(66, 15);
            this.lbl_lefttime.TabIndex = 5;
            this.lbl_lefttime.Text = "남은 시간 :";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // StudentOX
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 393);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_lefttime);
            this.Controls.Add(this.pn_no);
            this.Controls.Add(this.pn_yes);
            this.Controls.Add(this.label1);
            this.Name = "StudentOX";
            this.Text = "O,X 퀴즈";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pn_yes;
        private System.Windows.Forms.Panel pn_no;
        private System.Windows.Forms.Label lbl_lefttime;
        private System.Windows.Forms.Timer Timer;
    }
}

