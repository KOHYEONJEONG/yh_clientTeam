
namespace ProgramMain
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_screenCopy = new System.Windows.Forms.Button();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAsk = new System.Windows.Forms.CheckBox();
            this.chkImage = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_screenCopy);
            this.groupBox1.Controls.Add(this.pctBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이미지";
            // 
            // btn_screenCopy
            // 
            this.btn_screenCopy.Location = new System.Drawing.Point(174, 275);
            this.btn_screenCopy.Name = "btn_screenCopy";
            this.btn_screenCopy.Size = new System.Drawing.Size(94, 29);
            this.btn_screenCopy.TabIndex = 2;
            this.btn_screenCopy.Text = "화면캡쳐";
            this.btn_screenCopy.UseVisualStyleBackColor = true;
            this.btn_screenCopy.Click += new System.EventHandler(this.btn_screenCopy_Click);
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pctBox.Location = new System.Drawing.Point(9, 26);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(414, 245);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            this.pctBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBox);
            this.groupBox2.Location = new System.Drawing.Point(1, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "질문";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(9, 26);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(411, 234);
            this.txtBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"JPEG|*.jpg|PNG|*.png|Bitmap|*.bmp“ ";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.ValidateNames = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAsk);
            this.groupBox3.Controls.Add(this.chkImage);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Location = new System.Drawing.Point(1, 637);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "전송대상";
            // 
            // chkAsk
            // 
            this.chkAsk.AutoSize = true;
            this.chkAsk.Location = new System.Drawing.Point(186, 23);
            this.chkAsk.Name = "chkAsk";
            this.chkAsk.Size = new System.Drawing.Size(61, 24);
            this.chkAsk.TabIndex = 5;
            this.chkAsk.Text = "질문";
            this.chkAsk.UseVisualStyleBackColor = true;
            // 
            // chkImage
            // 
            this.chkImage.AutoSize = true;
            this.chkImage.Location = new System.Drawing.Point(93, 23);
            this.chkImage.Name = "chkImage";
            this.chkImage.Size = new System.Drawing.Size(76, 24);
            this.chkImage.TabIndex = 4;
            this.chkImage.Text = "이미지";
            this.chkImage.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(273, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Student_askf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(438, 698);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Student_askf";
            this.Load += new System.EventHandler(this.Student_askf_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_screenCopy;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.CheckBox chkAsk;
        private System.Windows.Forms.CheckBox chkImage;
        private System.Windows.Forms.Button btnSend;
    }
}