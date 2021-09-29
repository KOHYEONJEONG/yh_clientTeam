
namespace WinForms_Reply
{
    partial class ReplyForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.grpStd = new System.Windows.Forms.GroupBox();
            this.grpAnswer = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpStd.SuspendLayout();
            this.grpAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름 : ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(188, 15);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(41, 12);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "학번 : ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.White;
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswer.Location = new System.Drawing.Point(13, 28);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(524, 84);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.TabStop = false;
            // 
            // grpStd
            // 
            this.grpStd.BackColor = System.Drawing.Color.White;
            this.grpStd.Controls.Add(this.lblNum);
            this.grpStd.Controls.Add(this.lblName);
            this.grpStd.Location = new System.Drawing.Point(43, 16);
            this.grpStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStd.Name = "grpStd";
            this.grpStd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStd.Size = new System.Drawing.Size(557, 34);
            this.grpStd.TabIndex = 3;
            this.grpStd.TabStop = false;
            // 
            // grpAnswer
            // 
            this.grpAnswer.AutoSize = true;
            this.grpAnswer.BackColor = System.Drawing.Color.White;
            this.grpAnswer.Controls.Add(this.txtAnswer);
            this.grpAnswer.Location = new System.Drawing.Point(43, 61);
            this.grpAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAnswer.Name = "grpAnswer";
            this.grpAnswer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAnswer.Size = new System.Drawing.Size(557, 142);
            this.grpAnswer.TabIndex = 3;
            this.grpAnswer.TabStop = false;
            this.grpAnswer.Text = "답변";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(513, 209);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 26);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ReplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 246);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpAnswer);
            this.Controls.Add(this.grpStd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReplyForm";
            this.Text = "학생 응답";
            this.Load += new System.EventHandler(this.ReplyForm_Load);
            this.grpStd.ResumeLayout(false);
            this.grpStd.PerformLayout();
            this.grpAnswer.ResumeLayout(false);
            this.grpAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.GroupBox grpStd;
        private System.Windows.Forms.GroupBox grpAnswer;
        private System.Windows.Forms.Button btnOk;
    }
}

