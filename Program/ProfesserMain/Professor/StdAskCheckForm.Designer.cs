
namespace ProgramMain
{
    partial class StdAskCheckForm
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
            this.pbQuestionImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbStdQuestion = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이미지";
            // 
            // pbQuestionImg
            // 
            this.pbQuestionImg.BackColor = System.Drawing.Color.White;
            this.pbQuestionImg.Location = new System.Drawing.Point(6, 32);
            this.pbQuestionImg.Name = "pbQuestionImg";
            this.pbQuestionImg.Size = new System.Drawing.Size(332, 184);
            this.pbQuestionImg.TabIndex = 1;
            this.pbQuestionImg.TabStop = false;
            this.pbQuestionImg.Click += new System.EventHandler(this.pbQuestionImg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "질문";
            // 
            // rtbStdQuestion
            // 
            this.rtbStdQuestion.Location = new System.Drawing.Point(6, 248);
            this.rtbStdQuestion.Name = "rtbStdQuestion";
            this.rtbStdQuestion.ReadOnly = true;
            this.rtbStdQuestion.Size = new System.Drawing.Size(332, 176);
            this.rtbStdQuestion.TabIndex = 3;
            this.rtbStdQuestion.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(135, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StdAskCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(344, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbStdQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbQuestionImg);
            this.Controls.Add(this.label1);
            this.Name = "StdAskCheckForm";
            this.Text = "학생 질문";
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbQuestionImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbStdQuestion;
        private System.Windows.Forms.Button button1;
    }
}