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
        /// ����������
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
            sb.Append("��");
            sb.Append(nTotalDays.ToString());
            sb.Append("��");

            if (nTotalDays > 7)
            {
                sb.Append(";");
                sb.Append(nWeek.ToString());
                sb.Append("��");
                if (nWeekDay > 0)
                {
                    sb.Append("��");
                    sb.Append(nWeekDay.ToString());
                    sb.Append("��");
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
                MessageBox.Show("�������������!");
                return;
            }
            try{
                nDaysDiff = Convert.ToInt32(txtDaysDiff.Text);
            }
            catch{
                MessageBox.Show("�������������һ������!");
                return;
            }

            DateTime tmResult = dtStart + (new TimeSpan(nDaysDiff, 0, 0, 0));
            lblResult.Text = tmResult.ToString("yyyy��M��d��");
        }

        private void btnToLunarDate_Click(object sender, EventArgs e)
        {
            System.Globalization.ChineseLunisolarCalendar lunarCaledar = new System.Globalization.ChineseLunisolarCalendar();
            int nYear = lunarCaledar.GetYear(dpSolarDate.Value.Date);
            int nMonth = lunarCaledar.GetMonth(dpSolarDate.Value.Date);
            int nDay = lunarCaledar.GetDayOfMonth(dpSolarDate.Value.Date);

            int nLeepMonth = lunarCaledar.GetLeapMonth(nYear);

            StringBuilder sb = new StringBuilder();
            sb.Append("����");
            sb.Append(nYear.ToString());
            sb.Append("��");

            if (nLeepMonth == nMonth)
            {
                sb.Append("��");
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

            sb.Append("��");
            sb.Append(ChineseDayName[nDay - 1]);
            sb.Append("��");

            lblResult.Text = sb.ToString();
        }

        public const string ChineseNumber = "��һ�����������߰˾�";
        public const string CelestialStem = "���ұ����켺�����ɹ�";
        public const string TerrestrialBranch = "�ӳ���î������δ�����纥";
        public const string Animals = "��ţ������������Ｆ����";
        public static readonly string[] ChineseWeekName = new string[] { "������", "����һ", "���ڶ�", "������", "������", "������", "������" };
        public static readonly string[] ChineseDayName = new string[] {
            "��һ","����","����","����","����","����","����","����","����","��ʮ",
            "ʮһ","ʮ��","ʮ��","ʮ��","ʮ��","ʮ��","ʮ��","ʮ��","ʮ��","��ʮ",
            "إһ","إ��","إ��","إ��","إ��","إ��","إ��","إ��","إ��","��ʮ"};
        public static readonly string[] ChineseMonthName = new string[] { "��", "��", "��", "��", "��", "��", "��", "��", "��", "ʮ", "ʮһ", "ʮ��" };

        private void btnToSolarDate_Click(object sender, EventArgs e)
        {
            try
            {
                int nYear = Convert.ToInt32(txtLunarYear.Text.Trim());
                int nMonth = Convert.ToInt32(txtLunarMonth.Text.Trim());
                int nDay = Convert.ToInt32(txtLunarDay.Text.Trim());

                DateTime tm = GetDateFromLunarDate(nYear, nMonth, nDay, chkIsLeepMonth.Checked);

                lblResult.Text = tm.ToString("����yyyy��M��d��");
            }catch(Exception ex)
            {
                MessageBox.Show("������Ϸ����������ڣ�");

            }
        }



        /// <summary>
        /// ����ת����
        /// </summary>
        /// <param name="year">������</param>
        /// <param name="month">������</param>
        /// <param name="day">������</param>
        /// <param name="IsLeapMonth">�Ƿ�����</param>
        public static DateTime GetDateFromLunarDate(int year, int month, int day, bool IsLeapMonth)
        {
            System.Globalization.ChineseLunisolarCalendar lunarCaledar = new System.Globalization.ChineseLunisolarCalendar();
           

            if (year < 1902 || year > 2100)
                throw new Exception("ֻ֧��1902��2100�ڼ��������");
            if (month < 1 || month > 12)
                throw new Exception("��ʾ�·ݵ����ֱ�����1��12֮��");

            if (day < 1 || day > lunarCaledar.GetDaysInMonth(year, month))
                throw new Exception("����������������");

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
        /// ��ȡָ����ݴ��ڵ��գ����³�һ������������
        /// </summary>
        /// <param name="year">ָ�������</param>
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
                MessageBox.Show("�޷�����http://www.urtracker.cn");
            }
        }
        
    }
}