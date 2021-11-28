
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
            this.nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이미지";
            // 
            // pbQuestionImg
            // 
            this.pbQuestionImg.BackColor = System.Drawing.Color.White;
            this.pbQuestionImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQuestionImg.Location = new System.Drawing.Point(6, 68);
            this.pbQuestionImg.Name = "pbQuestionImg";
            this.pbQuestionImg.Size = new System.Drawing.Size(332, 184);
            this.pbQuestionImg.TabIndex = 1;
            this.pbQuestionImg.TabStop = false;
            this.pbQuestionImg.Click += new System.EventHandler(this.pbQuestionImg_Click);
            this.pbQuestionImg.DoubleClick += new System.EventHandler(this.pbQuestionImg_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "질문";
            // 
            // rtbStdQuestion
            // 
            this.rtbStdQuestion.Location = new System.Drawing.Point(6, 279);
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
            this.button1.Location = new System.Drawing.Point(135, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(9, 12);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(54, 21);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "label3";
            // 
            // StdAskCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(344, 495);
            this.Controls.Add(this.nameLbl);
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
        private System.Windows.Forms.Label nameLbl;
    }
}