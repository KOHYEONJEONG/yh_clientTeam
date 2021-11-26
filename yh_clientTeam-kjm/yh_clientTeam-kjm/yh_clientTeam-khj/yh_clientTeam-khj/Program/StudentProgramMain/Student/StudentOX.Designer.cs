
namespace StudentProgramMain.Student
{
    partial class StudentOX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentOX));
            this.lbl_lefttime = new System.Windows.Forms.Label();
            this.lbl_q = new System.Windows.Forms.Label();
            this.btn_o = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.lefttime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_lefttime
            // 
            this.lbl_lefttime.AutoSize = true;
            this.lbl_lefttime.ForeColor = System.Drawing.Color.Red;
            this.lbl_lefttime.Location = new System.Drawing.Point(1, 3);
            this.lbl_lefttime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lefttime.Name = "lbl_lefttime";
            this.lbl_lefttime.Size = new System.Drawing.Size(70, 15);
            this.lbl_lefttime.TabIndex = 0;
            this.lbl_lefttime.Text = "남은 시간 : ";
            // 
            // lbl_q
            // 
            this.lbl_q.AutoSize = true;
            this.lbl_q.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_q.ForeColor = System.Drawing.Color.White;
            this.lbl_q.Location = new System.Drawing.Point(41, 52);
            this.lbl_q.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(30, 19);
            this.lbl_q.TabIndex = 1;
            this.lbl_q.Text = "Q) ";
            this.lbl_q.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_o
            // 
            this.btn_o.FlatAppearance.BorderSize = 0;
            this.btn_o.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_o.Image = ((System.Drawing.Image)(resources.GetObject("btn_o.Image")));
            this.btn_o.Location = new System.Drawing.Point(1, 93);
            this.btn_o.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(258, 291);
            this.btn_o.TabIndex = 2;
            this.btn_o.UseVisualStyleBackColor = true;
            this.btn_o.Click += new System.EventHandler(this.btn_o_Click);
            // 
            // btn_x
            // 
            this.btn_x.FlatAppearance.BorderSize = 0;
            this.btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x.Image = ((System.Drawing.Image)(resources.GetObject("btn_x.Image")));
            this.btn_x.Location = new System.Drawing.Point(263, 101);
            this.btn_x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(253, 275);
            this.btn_x.TabIndex = 3;
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // lefttime
            // 
            this.lefttime.Interval = 1000;
            this.lefttime.Tick += new System.EventHandler(this.lefttime_Tick);
            // 
            // StudentOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(529, 386);
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.btn_o);
            this.Controls.Add(this.lbl_q);
            this.Controls.Add(this.lbl_lefttime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentOX";
            this.Text = "StudentOX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lefttime;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.Button btn_o;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Timer lefttime;
    }
}