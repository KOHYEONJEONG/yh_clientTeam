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
            this.label1 = new System.Windows.Forms.Label();
            this.allcheck = new System.Windows.Forms.CheckBox();
            this.screenbtn = new System.Windows.Forms.Button();
            this.questionbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.allscreenbtn = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.Label();
            this.classTime = new System.Windows.Forms.Label();
            this.attenddanceBtn = new System.Windows.Forms.Button();
            this.nowTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "선택";
            // 
            // allcheck
            // 
            this.allcheck.AutoSize = true;
            this.allcheck.Location = new System.Drawing.Point(35, 114);
            this.allcheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allcheck.Name = "allcheck";
            this.allcheck.Size = new System.Drawing.Size(15, 14);
            this.allcheck.TabIndex = 7;
            this.allcheck.UseVisualStyleBackColor = true;
            this.allcheck.CheckedChanged += new System.EventHandler(this.allcheck_CheckedChanged);
            // 
            // screenbtn
            // 
            this.screenbtn.Location = new System.Drawing.Point(97, 448);
            this.screenbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.screenbtn.Name = "screenbtn";
            this.screenbtn.Size = new System.Drawing.Size(69, 29);
            this.screenbtn.TabIndex = 10;
            this.screenbtn.Text = "스크린샷";
            this.screenbtn.UseVisualStyleBackColor = true;
            this.screenbtn.Click += new System.EventHandler(this.screenbtn_Click);
            // 
            // questionbtn
            // 
            this.questionbtn.Location = new System.Drawing.Point(28, 448);
            this.questionbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionbtn.Name = "questionbtn";
            this.questionbtn.Size = new System.Drawing.Size(63, 29);
            this.questionbtn.TabIndex = 10;
            this.questionbtn.Text = "문제";
            this.questionbtn.UseVisualStyleBackColor = true;
            this.questionbtn.Click += new System.EventHandler(this.questionbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "학생 리스트";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // allscreenbtn
            // 
            this.allscreenbtn.Location = new System.Drawing.Point(172, 448);
            this.allscreenbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allscreenbtn.Name = "allscreenbtn";
            this.allscreenbtn.Size = new System.Drawing.Size(130, 29);
            this.allscreenbtn.TabIndex = 15;
            this.allscreenbtn.Text = "전체 스크린샷 확인";
            this.allscreenbtn.UseVisualStyleBackColor = true;
            this.allscreenbtn.Click += new System.EventHandler(this.allscreenbtn_Click);
            // 
            // attendBtn
            // 
            this.attendBtn.Location = new System.Drawing.Point(578, 448);
            this.attendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendBtn.Name = "attendBtn";
            this.attendBtn.Size = new System.Drawing.Size(80, 29);
            this.attendBtn.TabIndex = 16;
            this.attendBtn.Text = "출석시작";
            this.attendBtn.UseVisualStyleBackColor = true;
            this.attendBtn.Visible = false;
            this.attendBtn.Click += new System.EventHandler(this.attendbtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(578, 448);
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
            this.endBtn.Location = new System.Drawing.Point(578, 448);
            this.endBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(80, 29);
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
            this.studList.Location = new System.Drawing.Point(28, 108);
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
            this.studList.Size = new System.Drawing.Size(626, 332);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(208, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "수업 시간 : ";
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.className.Location = new System.Drawing.Point(12, 14);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(190, 40);
            this.className.TabIndex = 24;
            this.className.Text = "수업 이름";
            this.className.Click += new System.EventHandler(this.className_Click);
            // 
            // classTime
            // 
            this.classTime.AutoSize = true;
            this.classTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classTime.Location = new System.Drawing.Point(324, 36);
            this.classTime.Name = "classTime";
            this.classTime.Size = new System.Drawing.Size(48, 16);
            this.classTime.TabIndex = 25;
            this.classTime.Text = "label8";
            // 
            // attenddanceBtn
            // 
            this.attenddanceBtn.Location = new System.Drawing.Point(308, 448);
            this.attenddanceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attenddanceBtn.Name = "attenddanceBtn";
            this.attenddanceBtn.Size = new System.Drawing.Size(87, 29);
            this.attenddanceBtn.TabIndex = 26;
            this.attenddanceBtn.Text = "출석부 확인";
            this.attenddanceBtn.UseVisualStyleBackColor = true;
            this.attenddanceBtn.Click += new System.EventHandler(this.attenddanceBtn_Click);
            // 
            // nowTime
            // 
            this.nowTime.AutoSize = true;
            this.nowTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nowTime.Location = new System.Drawing.Point(578, 38);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(48, 16);
            this.nowTime.TabIndex = 28;
            this.nowTime.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(463, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "현재 시간 : ";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ProfesserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 495);
            this.Controls.Add(this.nowTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.attenddanceBtn);
            this.Controls.Add(this.classTime);
            this.Controls.Add(this.className);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.allcheck);
            this.Controls.Add(this.studList);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.attendBtn);
            this.Controls.Add(this.allscreenbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionbtn);
            this.Controls.Add(this.screenbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProfesserMain";
            this.Text = "메인화면";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox allcheck;
        private System.Windows.Forms.Button screenbtn;
        private System.Windows.Forms.Button questionbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button allscreenbtn;
        private System.Windows.Forms.Button attendBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.DataGridView studList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.Label classTime;
        private System.Windows.Forms.Button attenddanceBtn;
        private System.Windows.Forms.Label nowTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stucheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewImageColumn stuscreenshot;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuanswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuattend;
    }
}

