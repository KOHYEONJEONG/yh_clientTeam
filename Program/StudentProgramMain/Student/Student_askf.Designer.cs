
namespace StudentProgramMain.Student
{
    partial class Student_askf
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkImage = new System.Windows.Forms.CheckBox();
            this.chkAsk = new System.Windows.Forms.CheckBox();
            this.btn_screenCopy = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctBox);
            this.groupBox1.Controls.Add(this.btn_screenCopy);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이미지";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBox);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(7, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 275);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "질문";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.chkAsk);
            this.groupBox3.Controls.Add(this.chkImage);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(7, 622);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 71);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "전송대상";
            // 
            // chkImage
            // 
            this.chkImage.AutoSize = true;
            this.chkImage.Location = new System.Drawing.Point(95, 28);
            this.chkImage.Name = "chkImage";
            this.chkImage.Size = new System.Drawing.Size(83, 27);
            this.chkImage.TabIndex = 0;
            this.chkImage.Text = "이미지";
            this.chkImage.UseVisualStyleBackColor = true;
            // 
            // chkAsk
            // 
            this.chkAsk.AutoSize = true;
            this.chkAsk.Location = new System.Drawing.Point(198, 29);
            this.chkAsk.Name = "chkAsk";
            this.chkAsk.Size = new System.Drawing.Size(66, 27);
            this.chkAsk.TabIndex = 1;
            this.chkAsk.Text = "질문";
            this.chkAsk.UseVisualStyleBackColor = true;
            // 
            // btn_screenCopy
            // 
            this.btn_screenCopy.BackColor = System.Drawing.Color.White;
            this.btn_screenCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_screenCopy.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_screenCopy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_screenCopy.Location = new System.Drawing.Point(170, 273);
            this.btn_screenCopy.Name = "btn_screenCopy";
            this.btn_screenCopy.Size = new System.Drawing.Size(94, 29);
            this.btn_screenCopy.TabIndex = 2;
            this.btn_screenCopy.Text = "화면캡쳐";
            this.btn_screenCopy.UseVisualStyleBackColor = false;
            this.btn_screenCopy.Click += new System.EventHandler(this.btn_screenCopy_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSend.Location = new System.Drawing.Point(312, 26);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.Color.White;
            this.pctBox.Location = new System.Drawing.Point(10, 26);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(414, 245);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox.TabIndex = 3;
            this.pctBox.TabStop = false;
            this.pctBox.Click += new System.EventHandler(this.pctBox_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(3, 26);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox.Size = new System.Drawing.Size(428, 243);
            this.txtBox.TabIndex = 0;
            // 
            // Student_askf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(450, 698);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Student_askf";
            this.Text = "질문 보내기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_askf_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_screenCopy;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chkAsk;
        private System.Windows.Forms.CheckBox chkImage;
        private System.Windows.Forms.PictureBox pctBox;
        internal System.Windows.Forms.TextBox txtBox;
    }
}