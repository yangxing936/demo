using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var csss = "一二三四五六七八九滚一队伍";


            csss = csss.Substring(0, 9) + "....";






            var json = "[{\"BeginTime\":\"00:00\",\"EndTime\":\"00:01\",\"week\":\"1\"},{\"BeginTime\":\"00:02\",\"EndTime\":\"00:03\",\"week\":\"1\"}]";
            var text = "";
            var Time = JsonConvert.DeserializeObject<List<Time>>(json);
            for (int i = 0; i < Time.Count; i++)
            {
                Time[i].Id = i.ToString();
            }
            foreach (var item in Time)
            {
                //结束时间等于开始时间
                if (item.BeginTime == item.EndTime)
                {
                    text += "开始时间不能跟结束时间相同,";
                }
                //结束时间小于开始时间
                if (TimeCompare(item.EndTime, item.BeginTime) < 0)
                {
                    text += "结束时间不能小于开始时间,";
                }
                if (item.week.IndexOf(',') >= 0)
                {
                    var idList = item.week.Split(',').ToList();
                    foreach (var ids in idList)
                    {
                        //获取当前循环外的数据
                        var list = Time.Where(s => s.Id != item.Id && s.week.IndexOf
                        (ids) >= 0).ToList();
                        foreach (var em in list)
                        {
                            var isTrue1 = getTimeSpan(item.BeginTime, em.BeginTime, em.EndTime);
                            var isTrue2 = getTimeSpan(item.EndTime, em.BeginTime, em.EndTime);
                            if (isTrue1 != false || isTrue2 != false)
                            {
                                text += "星期相同时间不能交叉,";
                            }
                        }
                    }

                }
                else
                {
                    //获取当前循环外的数据
                    var list = Time.Where(s => s.Id != item.Id && s.week == item.week).ToList();
                    foreach (var em in list)
                    {
                        var isTrue1 = getTimeSpan(item.BeginTime, em.BeginTime, em.EndTime);
                        var isTrue2 = getTimeSpan(item.EndTime, em.BeginTime, em.EndTime);
                        if (isTrue1 != false || isTrue2 != false)
                        {
                            text += "星期相同时间不能交叉,";
                        }
                    }
                }

            }

            var ccc = text;
            Console.Read();


        }
        public class Time
        {
            public string Id { get; set; }
            public string BeginTime { get; set; }
            public string EndTime { get; set; }
            public string week { get; set; }
        }
        /// <summary>
        /// 1 大于 -1 小于 0 等于
        /// </summary>
        /// <param name="Time1"></param>
        /// <param name="Time2"></param>
        /// <returns></returns>
        public static int TimeCompare(string Time1, string Time2)
        {
            DateTime dt1 = Convert.ToDateTime(Time1);
            DateTime dt2 = Convert.ToDateTime(Time2);
            var res = DateTime.Compare(dt1, dt2);
            return res;
        }
        public static bool getTimeSpan(string timeStr, string BeginTime, string EndTime)
        {
            //判断当前时间是否在工作时间段内
            string _strWorkingDayAM = BeginTime;//工作时间上午08:30
            string _strWorkingDayPM = EndTime;
            TimeSpan dspWorkingDayAM = DateTime.Parse(_strWorkingDayAM).TimeOfDay;
            TimeSpan dspWorkingDayPM = DateTime.Parse(_strWorkingDayPM).TimeOfDay;

            DateTime t1 = Convert.ToDateTime(timeStr);

            TimeSpan dspNow = t1.TimeOfDay;
            if (dspNow >= dspWorkingDayAM && dspNow <= dspWorkingDayPM)
            {
                return true;
            }
            return false;
        }
    }

}

