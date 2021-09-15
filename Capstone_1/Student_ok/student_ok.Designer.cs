
namespace Student_ok
{
    partial class student_ok
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
            this.label1 = new System.Windows.Forms.Label();
            this.O_btn = new System.Windows.Forms.Button();
            this.X_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "문제 :";
            // 
            // O_btn
            // 
            this.O_btn.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.O_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.O_btn.Location = new System.Drawing.Point(34, 74);
            this.O_btn.Name = "O_btn";
            this.O_btn.Size = new System.Drawing.Size(162, 168);
            this.O_btn.TabIndex = 1;
            this.O_btn.Text = "O";
            this.O_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.O_btn.UseVisualStyleBackColor = true;
            // 
            // X_btn
            // 
            this.X_btn.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X_btn.ForeColor = System.Drawing.Color.Red;
            this.X_btn.Location = new System.Drawing.Point(212, 74);
            this.X_btn.Name = "X_btn";
            this.X_btn.Size = new System.Drawing.Size(157, 168);
            this.X_btn.TabIndex = 1;
            this.X_btn.Text = "X";
            this.X_btn.UseVisualStyleBackColor = true;
            // 
            // student_ok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(406, 298);
            this.ControlBox = false;
            this.Controls.Add(this.X_btn);
            this.Controls.Add(this.O_btn);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "student_ok";
            this.Text = "O,X 퀴즈";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button O_btn;
        private System.Windows.Forms.Button X_btn;
    }
}

