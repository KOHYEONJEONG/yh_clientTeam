
namespace ProfessorMain
{
    partial class ReplyYNForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.grpAnswer = new System.Windows.Forms.GroupBox();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.grpStd = new System.Windows.Forms.GroupBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpAnswer.SuspendLayout();
            this.grpStd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(368, 154);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 26);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpAnswer
            // 
            this.grpAnswer.AutoSize = true;
            this.grpAnswer.BackColor = System.Drawing.Color.White;
            this.grpAnswer.Controls.Add(this.radioYes);
            this.grpAnswer.Controls.Add(this.radioNo);
            this.grpAnswer.Location = new System.Drawing.Point(36, 69);
            this.grpAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAnswer.Name = "grpAnswer";
            this.grpAnswer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAnswer.Size = new System.Drawing.Size(407, 67);
            this.grpAnswer.TabIndex = 5;
            this.grpAnswer.TabStop = false;
            this.grpAnswer.Text = "답변";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Enabled = false;
            this.radioYes.Location = new System.Drawing.Point(135, 28);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(45, 16);
            this.radioYes.TabIndex = 8;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Enabled = false;
            this.radioNo.Location = new System.Drawing.Point(244, 28);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 16);
            this.radioNo.TabIndex = 9;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // grpStd
            // 
            this.grpStd.BackColor = System.Drawing.Color.White;
            this.grpStd.Controls.Add(this.lblNum);
            this.grpStd.Controls.Add(this.lblName);
            this.grpStd.Location = new System.Drawing.Point(36, 24);
            this.grpStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStd.Name = "grpStd";
            this.grpStd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStd.Size = new System.Drawing.Size(407, 34);
            this.grpStd.TabIndex = 6;
            this.grpStd.TabStop = false;
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름 : ";
            // 
            // ReplyYNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 204);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpAnswer);
            this.Controls.Add(this.grpStd);
            this.Name = "ReplyYNForm";
            this.Text = "학생 응답";
            this.grpAnswer.ResumeLayout(false);
            this.grpAnswer.PerformLayout();
            this.grpStd.ResumeLayout(false);
            this.grpStd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpAnswer;
        private System.Windows.Forms.GroupBox grpStd;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
    }
}