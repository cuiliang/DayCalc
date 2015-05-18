using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DayCalc
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算天数差
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComputeTimeSpan_Click(object sender, EventArgs e)
        {
            DateTime dtStart = dpStartDate.Value.Date;
            DateTime dtEnd = dpEndDate.Value.Date;

            TimeSpan span = dtStart - dtEnd;
            if (span.Ticks < 0)
            {
                span = -span;
            }

            int nTotalDays = Convert.ToInt32(Math.Ceiling(span.TotalDays));

            int nWeek = nTotalDays / 7;
            int nWeekDay = nTotalDays % 7;


            StringBuilder sb = new StringBuilder(100);
            sb.Append("相差共");
            sb.Append(nTotalDays.ToString());
            sb.Append("天");

            if (nTotalDays > 7)
            {
                sb.Append(";");
                sb.Append(nWeek.ToString());
                sb.Append("周");
                if (nWeekDay > 0)
                {
                    sb.Append("加");
                    sb.Append(nWeekDay.ToString());
                    sb.Append("天");
                }
            }

            if (nTotalDays > 30)
            {
                sb.Append(";");
                sb.Append(DateHelper.GetDateDiffString(dtStart, dtEnd));
            }

            lblResult.Text = sb.ToString();
        }

        private void btnComputeDate_Click(object sender, EventArgs e)
        {
            DateTime dtStart = dpStartDate1.Value.Date;

            int nDaysDiff = 0;
            if (txtDaysDiff.Text.Length < 1 )
            {
                MessageBox.Show("请输入相隔天数!");
                return;
            }
            try{
                nDaysDiff = Convert.ToInt32(txtDaysDiff.Text);
            }
            catch{
                MessageBox.Show("相隔天数请输入一个数字!");
                return;
            }

            DateTime tmResult = dtStart + (new TimeSpan(nDaysDiff, 0, 0, 0));
            lblResult.Text = tmResult.ToString("yyyy年M月d日");
        }

        private void btnToLunarDate_Click(object sender, EventArgs e)
        {
            System.Globalization.ChineseLunisolarCalendar lunarCaledar = new System.Globalization.ChineseLunisolarCalendar();
            int nYear = lunarCaledar.GetYear(dpSolarDate.Value.Date);
            int nMonth = lunarCaledar.GetMonth(dpSolarDate.Value.Date);
            int nDay = lunarCaledar.GetDayOfMonth(dpSolarDate.Value.Date);

            int nLeepMonth = lunarCaledar.GetLeapMonth(nYear);

            StringBuilder sb = new StringBuilder();
            sb.Append("阴历");
            sb.Append(nYear.ToString());
            sb.Append("年");

            if (nLeepMonth == nMonth)
            {
                sb.Append("润");
                sb.Append(ChineseMonthName[nMonth - 1 -1]);
            }else{
                if (nLeepMonth > 0  && nMonth > nLeepMonth)
                {
                    sb.Append(ChineseMonthName[nMonth - 1 -1]);
                }else
                {
                    sb.Append(ChineseMonthName[nMonth - 1]);
                }
            }

            sb.Append("月");
            sb.Append(ChineseDayName[nDay - 1]);
            sb.Append("日");

            lblResult.Text = sb.ToString();
        }

        public const string ChineseNumber = "〇一二三四五六七八九";
        public const string CelestialStem = "甲乙丙丁戊己庚辛壬癸";
        public const string TerrestrialBranch = "子丑寅卯辰巳午未申酉戌亥";
        public const string Animals = "鼠牛虎兔龙蛇马羊猴鸡狗猪";
        public static readonly string[] ChineseWeekName = new string[] { "星期天", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
        public static readonly string[] ChineseDayName = new string[] {
            "初一","初二","初三","初四","初五","初六","初七","初八","初九","初十",
            "十一","十二","十三","十四","十五","十六","十七","十八","十九","二十",
            "廿一","廿二","廿三","廿四","廿五","廿六","廿七","廿八","廿九","三十"};
        public static readonly string[] ChineseMonthName = new string[] { "正", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二" };

        private void btnToSolarDate_Click(object sender, EventArgs e)
        {
            try
            {
                int nYear = Convert.ToInt32(txtLunarYear.Text.Trim());
                int nMonth = Convert.ToInt32(txtLunarMonth.Text.Trim());
                int nDay = Convert.ToInt32(txtLunarDay.Text.Trim());

                DateTime tm = GetDateFromLunarDate(nYear, nMonth, nDay, chkIsLeepMonth.Checked);

                lblResult.Text = tm.ToString("阳历yyyy年M月d日");
            }catch(Exception ex)
            {
                MessageBox.Show("请输入合法的阴历日期！");

            }
        }



        /// <summary>
        /// 阴历转阳历
        /// </summary>
        /// <param name="year">阴历年</param>
        /// <param name="month">阴历月</param>
        /// <param name="day">阴历日</param>
        /// <param name="IsLeapMonth">是否闰月</param>
        public static DateTime GetDateFromLunarDate(int year, int month, int day, bool IsLeapMonth)
        {
            System.Globalization.ChineseLunisolarCalendar lunarCaledar = new System.Globalization.ChineseLunisolarCalendar();
           

            if (year < 1902 || year > 2100)
                throw new Exception("只支持1902～2100期间的阴历年");
            if (month < 1 || month > 12)
                throw new Exception("表示月份的数字必须在1～12之间");

            if (day < 1 || day > lunarCaledar.GetDaysInMonth(year, month))
                throw new Exception("阴历日期输入有误");

            int num1 = 0, num2 = 0;
            int leapMonth = lunarCaledar.GetLeapMonth(year);

            if (((leapMonth == month + 1) && IsLeapMonth) || (leapMonth > 0 && leapMonth <= month))
                num2 = month;
            else
                num2 = month - 1;

            while (num2 > 0)
            {
                num1 += lunarCaledar.GetDaysInMonth(year, num2--);
            }

            DateTime dt = GetLunarNewYearDate(year);
            return dt.AddDays(num1 + day - 1);
        }


        /// <summary>
        /// 获取指定年份春节当日（正月初一）的阳历日期
        /// </summary>
        /// <param name="year">指定的年份</param>
        private static DateTime GetLunarNewYearDate(int year)
        {
            System.Globalization.ChineseLunisolarCalendar lunarCaledar = new System.Globalization.ChineseLunisolarCalendar();
           
            DateTime dt = new DateTime(year, 1, 1);
            int cnYear = lunarCaledar.GetYear(dt);
            int cnMonth = lunarCaledar.GetMonth(dt);

            int num1 = 0;
            int num2 = lunarCaledar.IsLeapYear(cnYear) ? 13 : 12;

            while (num2 >= cnMonth)
            {
                num1 += lunarCaledar.GetDaysInMonth(cnYear, num2--);
            }

            num1 = num1 - lunarCaledar.GetDayOfMonth(dt) + 1;
            return dt.AddDays(num1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.urtracker.cn");

            }
            catch
            {
                MessageBox.Show("无法访问http://www.urtracker.cn");
            }
        }
        
    }
}