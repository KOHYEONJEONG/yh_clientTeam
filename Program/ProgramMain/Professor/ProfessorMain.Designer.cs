namespace ProgramMain
{
    partial class ProfesserMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allcheck = new System.Windows.Forms.CheckBox();
            this.attendBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.studList = new System.Windows.Forms.DataGridView();
            this.stucheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuscreenshot = new System.Windows.Forms.DataGridViewImageColumn();
            this.stuanswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuattend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowTime = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.attenddanceBtn = new FontAwesome.Sharp.IconButton();
            this.screenbtn = new FontAwesome.Sharp.IconButton();
            this.questionbtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProfname = new System.Windows.Forms.Label();
            this.classTime = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.studList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // allcheck
            // 
            this.allcheck.AutoSize = true;
            this.allcheck.Location = new System.Drawing.Point(171, 89);
            this.allcheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allcheck.Name = "allcheck";
            this.allcheck.Size = new System.Drawing.Size(15, 14);
            this.allcheck.TabIndex = 7;
            this.allcheck.UseVisualStyleBackColor = true;
            this.allcheck.CheckedChanged += new System.EventHandler(this.allcheck_CheckedChanged);
            // 
            // attendBtn
            // 
            this.attendBtn.Location = new System.Drawing.Point(593, 139);
            this.attendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendBtn.Name = "attendBtn";
            this.attendBtn.Size = new System.Drawing.Size(101, 27);
            this.attendBtn.TabIndex = 16;
            this.attendBtn.Text = "출석시작";
            this.attendBtn.UseVisualStyleBackColor = true;
            this.attendBtn.Visible = false;
            this.attendBtn.Click += new System.EventHandler(this.attendbtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(700, 137);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(80, 29);
            this.startBtn.TabIndex = 17;
            this.startBtn.Text = "수업시작";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(486, 139);
            this.endBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(101, 27);
            this.endBtn.TabIndex = 18;
            this.endBtn.Text = "수업종료";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Visible = false;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // studList
            // 
            this.studList.AllowUserToAddRows = false;
            this.studList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stucheck,
            this.stuid,
            this.stuname,
            this.stuscreenshot,
            this.stuanswer,
            this.stuattend});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studList.DefaultCellStyle = dataGridViewCellStyle3;
            this.studList.Location = new System.Drawing.Point(165, 83);
            this.studList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studList.Name = "studList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studList.RowHeadersVisible = false;
            this.studList.RowTemplate.Height = 75;
            this.studList.Size = new System.Drawing.Size(628, 404);
            this.studList.TabIndex = 19;
            this.studList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studList_CellDoubleClick);
            this.studList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studList_CellMouseDoubleClick);
            // 
            // stucheck
            // 
            this.stucheck.HeaderText = "";
            this.stucheck.Name = "stucheck";
            this.stucheck.Width = 25;
            // 
            // stuid
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stuid.DefaultCellStyle = dataGridViewCellStyle2;
            this.stuid.HeaderText = "학번";
            this.stuid.Name = "stuid";
            this.stuid.Width = 120;
            // 
            // stuname
            // 
            this.stuname.HeaderText = "이름";
            this.stuname.Name = "stuname";
            this.stuname.Width = 95;
            // 
            // stuscreenshot
            // 
            this.stuscreenshot.HeaderText = "스크린샷 썸네일";
            this.stuscreenshot.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.stuscreenshot.Name = "stuscreenshot";
            this.stuscreenshot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stuscreenshot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stuscreenshot.Width = 270;
            // 
            // stuanswer
            // 
            this.stuanswer.HeaderText = "응답";
            this.stuanswer.Name = "stuanswer";
            this.stuanswer.ReadOnly = true;
            this.stuanswer.Width = 55;
            // 
            // stuattend
            // 
            this.stuattend.HeaderText = "출석";
            this.stuattend.Name = "stuattend";
            this.stuattend.Width = 55;
            // 
            // nowTime
            // 
            this.nowTime.AutoSize = true;
            this.nowTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nowTime.ForeColor = System.Drawing.Color.White;
            this.nowTime.Location = new System.Drawing.Point(444, 47);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(189, 32);
            this.nowTime.TabIndex = 28;
            this.nowTime.Text = "현재 시간 : ";
            this.nowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.attenddanceBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.screenbtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.questionbtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProfname, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(161, 499);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // attenddanceBtn
            // 
            this.attenddanceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attenddanceBtn.FlatAppearance.BorderSize = 0;
            this.attenddanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attenddanceBtn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attenddanceBtn.ForeColor = System.Drawing.Color.White;
            this.attenddanceBtn.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.attenddanceBtn.IconColor = System.Drawing.Color.White;
            this.attenddanceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.attenddanceBtn.IconSize = 25;
            this.attenddanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attenddanceBtn.Location = new System.Drawing.Point(3, 193);
            this.attenddanceBtn.Name = "attenddanceBtn";
            this.attenddanceBtn.Size = new System.Drawing.Size(155, 49);
            this.attenddanceBtn.TabIndex = 31;
            this.attenddanceBtn.Text = "출석부";
            this.attenddanceBtn.UseVisualStyleBackColor = true;
            this.attenddanceBtn.Click += new System.EventHandler(this.attenddanceBtn_Click);
            // 
            // screenbtn
            // 
            this.screenbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenbtn.FlatAppearance.BorderSize = 0;
            this.screenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenbtn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.screenbtn.ForeColor = System.Drawing.Color.White;
            this.screenbtn.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.screenbtn.IconColor = System.Drawing.Color.White;
            this.screenbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.screenbtn.IconSize = 25;
            this.screenbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.screenbtn.Location = new System.Drawing.Point(3, 138);
            this.screenbtn.Name = "screenbtn";
            this.screenbtn.Size = new System.Drawing.Size(155, 49);
            this.screenbtn.TabIndex = 30;
            this.screenbtn.Text = "스크린샷";
            this.screenbtn.UseVisualStyleBackColor = true;
            this.screenbtn.Click += new System.EventHandler(this.screenbtn_Click);
            // 
            // questionbtn
            // 
            this.questionbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.questionbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionbtn.FlatAppearance.BorderSize = 0;
            this.questionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionbtn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionbtn.ForeColor = System.Drawing.Color.White;
            this.questionbtn.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.questionbtn.IconColor = System.Drawing.Color.White;
            this.questionbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.questionbtn.IconSize = 25;
            this.questionbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.questionbtn.Location = new System.Drawing.Point(3, 83);
            this.questionbtn.Name = "questionbtn";
            this.questionbtn.Size = new System.Drawing.Size(155, 49);
            this.questionbtn.TabIndex = 29;
            this.questionbtn.Text = "문제 전송";
            this.questionbtn.UseVisualStyleBackColor = true;
            this.questionbtn.Click += new System.EventHandler(this.questionbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "교수님";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProfname
            // 
            this.lblProfname.AutoSize = true;
            this.lblProfname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProfname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblProfname.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfname.ForeColor = System.Drawing.Color.White;
            this.lblProfname.Location = new System.Drawing.Point(3, 15);
            this.lblProfname.Name = "lblProfname";
            this.lblProfname.Size = new System.Drawing.Size(155, 25);
            this.lblProfname.TabIndex = 32;
            this.lblProfname.Text = "우체국";
            this.lblProfname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classTime
            // 
            this.classTime.AutoSize = true;
            this.classTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classTime.ForeColor = System.Drawing.Color.White;
            this.classTime.Location = new System.Drawing.Point(3, 47);
            this.classTime.Name = "classTime";
            this.classTime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.classTime.Size = new System.Drawing.Size(435, 32);
            this.classTime.TabIndex = 25;
            this.classTime.Text = "수업 시간 : ";
            this.classTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Dock = System.Windows.Forms.DockStyle.Fill;
            this.className.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.className.ForeColor = System.Drawing.Color.White;
            this.className.Location = new System.Drawing.Point(3, 0);
            this.className.Name = "className";
            this.className.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.className.Size = new System.Drawing.Size(435, 47);
            this.className.TabIndex = 24;
            this.className.Text = "수업 이름";
            this.className.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.className.Click += new System.EventHandler(this.className_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(90)))), ((int)(((byte)(61)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.49405F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50595F));
            this.tableLayoutPanel2.Controls.Add(this.className, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.classTime, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nowTime, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(162, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.30693F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.69307F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 79);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // ProfesserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(798, 494);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.allcheck);
            this.Controls.Add(this.attendBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.studList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProfesserMain";
            this.Text = "메인화면";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox allcheck;
        private System.Windows.Forms.Button attendBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.DataGridView studList;
        private System.Windows.Forms.Label nowTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stucheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewImageColumn stuscreenshot;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuanswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuattend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label classTime;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton questionbtn;
        private FontAwesome.Sharp.IconButton screenbtn;
        private FontAwesome.Sharp.IconButton attenddanceBtn;
        private System.Windows.Forms.Label lblProfname;
    }
}

