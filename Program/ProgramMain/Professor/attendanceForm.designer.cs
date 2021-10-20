
namespace ProgramMain
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
            this.stuNum = new System.Windows.Forms.ColumnHeader();
            this.stuName = new System.Windows.Forms.ColumnHeader();
            this.attendName = new System.Windows.Forms.Label();
            this.gradeLb = new System.Windows.Forms.Label();
            this.attendstatus = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // attendList
            // 
            this.attendList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stuNum,
            this.stuName,
            this.attendstatus});
            this.attendList.HideSelection = false;
            this.attendList.Location = new System.Drawing.Point(6, 74);
            this.attendList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendList.Name = "attendList";
            this.attendList.Size = new System.Drawing.Size(521, 363);
            this.attendList.TabIndex = 0;
            this.attendList.UseCompatibleStateImageBehavior = false;
            this.attendList.View = System.Windows.Forms.View.Details;
            // 
            // stuNum
            // 
            this.stuNum.Text = "학번";
            this.stuNum.Width = 190;
            // 
            // stuName
            // 
            this.stuName.Text = "이름";
            this.stuName.Width = 160;
            // 
            // attendName
            // 
            this.attendName.AutoSize = true;
            this.attendName.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attendName.Location = new System.Drawing.Point(103, 9);
            this.attendName.Name = "attendName";
            this.attendName.Size = new System.Drawing.Size(310, 40);
            this.attendName.TabIndex = 1;
            this.attendName.Text = "수업이름 출석부";
            // 
            // gradeLb
            // 
            this.gradeLb.AutoSize = true;
            this.gradeLb.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gradeLb.Location = new System.Drawing.Point(463, 52);
            this.gradeLb.Name = "gradeLb";
            this.gradeLb.Size = new System.Drawing.Size(61, 16);
            this.gradeLb.TabIndex = 2;
            this.gradeLb.Text = "학년/반";
            // 
            // attendstatus
            // 
            this.attendstatus.Text = "출석";
            this.attendstatus.Width = 160;
            // 
            // attendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 463);
            this.Controls.Add(this.gradeLb);
            this.Controls.Add(this.attendName);
            this.Controls.Add(this.attendList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ColumnHeader attendstatus;
    }
}