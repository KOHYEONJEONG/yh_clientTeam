
namespace ProfessorMain
{
    partial class attendanceForm
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
            this.attendList = new System.Windows.Forms.ListView();
            this.attendName = new System.Windows.Forms.Label();
            this.gradeLb = new System.Windows.Forms.Label();
            this.stuNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // attendList
            // 
            this.attendList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stuNum,
            this.stuName});
            this.attendList.HideSelection = false;
            this.attendList.Location = new System.Drawing.Point(3, 58);
            this.attendList.Name = "attendList";
            this.attendList.Size = new System.Drawing.Size(792, 391);
            this.attendList.TabIndex = 0;
            this.attendList.UseCompatibleStateImageBehavior = false;
            this.attendList.View = System.Windows.Forms.View.Details;
            // 
            // attendName
            // 
            this.attendName.AutoSize = true;
            this.attendName.Font = new System.Drawing.Font("굴림", 30F);
            this.attendName.Location = new System.Drawing.Point(235, 9);
            this.attendName.Name = "attendName";
            this.attendName.Size = new System.Drawing.Size(310, 40);
            this.attendName.TabIndex = 1;
            this.attendName.Text = "수업이름 출석부";
            // 
            // gradeLb
            // 
            this.gradeLb.AutoSize = true;
            this.gradeLb.Font = new System.Drawing.Font("굴림", 12F);
            this.gradeLb.Location = new System.Drawing.Point(726, 39);
            this.gradeLb.Name = "gradeLb";
            this.gradeLb.Size = new System.Drawing.Size(62, 16);
            this.gradeLb.TabIndex = 2;
            this.gradeLb.Text = "학년/반";
            // 
            // stuNum
            // 
            this.stuNum.Text = "학번";
            this.stuNum.Width = 80;
            // 
            // stuName
            // 
            this.stuName.Text = "이름";
            // 
            // attendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeLb);
            this.Controls.Add(this.attendName);
            this.Controls.Add(this.attendList);
            this.Name = "attendanceForm";
            this.Text = "attendanceForm";
            this.Load += new System.EventHandler(this.attendanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView attendList;
        private System.Windows.Forms.ColumnHeader stuNum;
        private System.Windows.Forms.ColumnHeader stuName;
        private System.Windows.Forms.Label attendName;
        private System.Windows.Forms.Label gradeLb;
    }
}