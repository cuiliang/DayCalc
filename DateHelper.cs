using System;
using System.Collections.Generic;
using System.Text;

namespace DayCalc
{
    class DateHelper
    {
        /// <summary>
        /// 得到时间差字符串
        /// </summary>
        /// <param name="dtEnd1"></param>
        /// <returns></returns>
        public static string GetDateDiffString(DateTime dtStart, DateTime dtEnd)
        {
            DateTime dtStart1, dtEnd1;
            if (dtStart > dtEnd)
            {
                dtStart1 = dtEnd;
                dtEnd1 = dtStart;
            }else
            {
                dtStart1 = dtStart;
                dtEnd1 = dtEnd;
                
            }

            //
            int year = 0, month = 0, day = 0;
            day = dtEnd1.Day - dtStart1.Day;
            if (day < 0)
            {
                day = dtEnd1.Day + (DateTime.DaysInMonth(dtStart1.Year, dtStart1.Month) - dtStart1.Day);
                month -= 1;
            }

            month += dtEnd1.Month - dtStart1.Month;
            if (month < 0)
            {
                month += 12;
                year -= 1;
            }
            year += dtEnd1.Year - dtStart1.Year;



            StringBuilder sb = new StringBuilder(100);

            
                    if (year > 0)
                    {
                        sb.Append(year.ToString());
                        sb.Append("年");
                    }
                    if (month > 0)
                    {
                        sb.Append(month.ToString());
                        sb.Append("个月");
                    }
                    if (day > 0)
                    {
                        sb.Append(day.ToString());
                        sb.Append("天");
                    }
                
            return sb.ToString();
        }



    }
}
