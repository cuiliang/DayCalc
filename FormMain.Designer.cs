namespace DayCalc
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnComputeTimeSpan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDaysDiff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dpStartDate1 = new System.Windows.Forms.DateTimePicker();
            this.btnComputeDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.linkHome = new System.Windows.Forms.LinkLabel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkIsLeepMonth = new System.Windows.Forms.CheckBox();
            this.txtLunarDay = new System.Windows.Forms.TextBox();
            this.txtLunarMonth = new System.Windows.Forms.TextBox();
            this.txtLunarYear = new System.Windows.Forms.TextBox();
            this.btnToSolarDate = new System.Windows.Forms.Button();
            this.btnToLunarDate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dpSolarDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始日期：";
            // 
            // dpStartDate
            // 
            this.dpStartDate.Location = new System.Drawing.Point(72, 18);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(130, 21);
            this.dpStartDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "结束日期：";
            // 
            // dpEndDate
            // 
            this.dpEndDate.Location = new System.Drawing.Point(72, 41);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(130, 21);
            this.dpEndDate.TabIndex = 3;
            // 
            // btnComputeTimeSpan
            // 
            this.btnComputeTimeSpan.Location = new System.Drawing.Point(224, 18);
            this.btnComputeTimeSpan.Name = "btnComputeTimeSpan";
            this.btnComputeTimeSpan.Size = new System.Drawing.Size(92, 42);
            this.btnComputeTimeSpan.TabIndex = 4;
            this.btnComputeTimeSpan.Text = "计算天数";
            this.btnComputeTimeSpan.UseVisualStyleBackColor = true;
            this.btnComputeTimeSpan.Click += new System.EventHandler(this.btnComputeTimeSpan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpStartDate);
            this.groupBox1.Controls.Add(this.btnComputeTimeSpan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dpEndDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "天数计算";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDaysDiff);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dpStartDate1);
            this.groupBox2.Controls.Add(this.btnComputeDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日期计算";
            // 
            // txtDaysDiff
            // 
            this.txtDaysDiff.Location = new System.Drawing.Point(72, 43);
            this.txtDaysDiff.Name = "txtDaysDiff";
            this.txtDaysDiff.Size = new System.Drawing.Size(130, 21);
            this.txtDaysDiff.TabIndex = 3;
            this.txtDaysDiff.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "相隔天数：";
            // 
            // dpStartDate1
            // 
            this.dpStartDate1.Location = new System.Drawing.Point(72, 19);
            this.dpStartDate1.Name = "dpStartDate1";
            this.dpStartDate1.Size = new System.Drawing.Size(130, 21);
            this.dpStartDate1.TabIndex = 1;
            // 
            // btnComputeDate
            // 
            this.btnComputeDate.Location = new System.Drawing.Point(224, 18);
            this.btnComputeDate.Name = "btnComputeDate";
            this.btnComputeDate.Size = new System.Drawing.Size(92, 41);
            this.btnComputeDate.TabIndex = 4;
            this.btnComputeDate.Text = "计算日期";
            this.btnComputeDate.UseVisualStyleBackColor = true;
            this.btnComputeDate.Click += new System.EventHandler(this.btnComputeDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "开始日期：";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(12, 250);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(355, 43);
            this.lblResult.TabIndex = 3;
            // 
            // linkHome
            // 
            this.linkHome.AutoSize = true;
            this.linkHome.Location = new System.Drawing.Point(9, 310);
            this.linkHome.Name = "linkHome";
            this.linkHome.Size = new System.Drawing.Size(89, 12);
            this.linkHome.TabIndex = 4;
            this.linkHome.TabStop = true;
            this.linkHome.Text = "访问本软件主页";
            this.linkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHome_LinkClicked);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(183, 306);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 21);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "软件信息...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(292, 306);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 21);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkIsLeepMonth);
            this.groupBox3.Controls.Add(this.txtLunarDay);
            this.groupBox3.Controls.Add(this.txtLunarMonth);
            this.groupBox3.Controls.Add(this.txtLunarYear);
            this.groupBox3.Controls.Add(this.btnToSolarDate);
            this.groupBox3.Controls.Add(this.btnToLunarDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dpSolarDate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "阴历阳历转换";
            // 
            // chkIsLeepMonth
            // 
            this.chkIsLeepMonth.AutoSize = true;
            this.chkIsLeepMonth.Location = new System.Drawing.Point(173, 43);
            this.chkIsLeepMonth.Name = "chkIsLeepMonth";
            this.chkIsLeepMonth.Size = new System.Drawing.Size(48, 16);
            this.chkIsLeepMonth.TabIndex = 7;
            this.chkIsLeepMonth.Text = "润月";
            this.chkIsLeepMonth.UseVisualStyleBackColor = true;
            // 
            // txtLunarDay
            // 
            this.txtLunarDay.Location = new System.Drawing.Point(145, 42);
            this.txtLunarDay.Name = "txtLunarDay";
            this.txtLunarDay.Size = new System.Drawing.Size(25, 21);
            this.txtLunarDay.TabIndex = 6;
            // 
            // txtLunarMonth
            // 
            this.txtLunarMonth.Location = new System.Drawing.Point(115, 42);
            this.txtLunarMonth.Name = "txtLunarMonth";
            this.txtLunarMonth.Size = new System.Drawing.Size(25, 21);
            this.txtLunarMonth.TabIndex = 5;
            // 
            // txtLunarYear
            // 
            this.txtLunarYear.Location = new System.Drawing.Point(72, 42);
            this.txtLunarYear.Name = "txtLunarYear";
            this.txtLunarYear.Size = new System.Drawing.Size(40, 21);
            this.txtLunarYear.TabIndex = 4;
            // 
            // btnToSolarDate
            // 
            this.btnToSolarDate.Location = new System.Drawing.Point(224, 42);
            this.btnToSolarDate.Name = "btnToSolarDate";
            this.btnToSolarDate.Size = new System.Drawing.Size(92, 21);
            this.btnToSolarDate.TabIndex = 8;
            this.btnToSolarDate.Text = "转阳历";
            this.btnToSolarDate.UseVisualStyleBackColor = true;
            this.btnToSolarDate.Click += new System.EventHandler(this.btnToSolarDate_Click);
            // 
            // btnToLunarDate
            // 
            this.btnToLunarDate.Location = new System.Drawing.Point(224, 18);
            this.btnToLunarDate.Name = "btnToLunarDate";
            this.btnToLunarDate.Size = new System.Drawing.Size(92, 21);
            this.btnToLunarDate.TabIndex = 2;
            this.btnToLunarDate.Text = "转阴历";
            this.btnToLunarDate.UseVisualStyleBackColor = true;
            this.btnToLunarDate.Click += new System.EventHandler(this.btnToLunarDate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "阴历日期：";
            // 
            // dpSolarDate
            // 
            this.dpSolarDate.Location = new System.Drawing.Point(72, 18);
            this.dpSolarDate.Name = "dpSolarDate";
            this.dpSolarDate.Size = new System.Drawing.Size(130, 21);
            this.dpSolarDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "阳历日期：";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 338);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.linkHome);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日期*天数计算器 --urtracker.cn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.Button btnComputeTimeSpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dpStartDate1;
        private System.Windows.Forms.Button btnComputeDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDaysDiff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.LinkLabel linkHome;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnToLunarDate;
        private System.Windows.Forms.DateTimePicker dpSolarDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnToSolarDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLunarYear;
        private System.Windows.Forms.CheckBox chkIsLeepMonth;
        private System.Windows.Forms.TextBox txtLunarDay;
        private System.Windows.Forms.TextBox txtLunarMonth;
    }
}

