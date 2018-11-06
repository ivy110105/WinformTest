using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    public static class Common
    {

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>      
        /// 释放内存      
        /// </summary>      
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        /// <summary>
        /// 数据库初始化
        /// </summary>
        public static void InitDB()
        {
            DBHelp.CreateTables.Create<Model.Schedule>();
        }

        public static void OpenNewForm(Form newform)
        {
            if (newform.ShowDialog() == DialogResult.OK)//对话框返回值为ok时运行
            {
                
            }
        }

        /// <summary>
        /// 重复的单位
        /// 例如：Repeat Every 4 days
        /// </summary>
        /// <returns></returns>
        public static List<string> RepeatUnit()
        {
            List<string> list = new List<string>();
            list.Add("days");
            list.Add("weeks");
            list.Add("months");
            list.Add("years");
            return list;
        }

        /// <summary>
        /// 计划类型
        /// </summary>
        /// <returns></returns>
        public static List<string> PlanType()
        {
            List<string> list = new List<string>();
            list.Add("工作");
            list.Add("健身");
            list.Add("阅读");
            list.Add("饮食");
            list.Add("作息");
            return list;
        }

        public static List<int> Years()
        {
            List<int> list = new List<int>();

            int loop = 3;
            var currentYear = DateTime.Now.Year;
            for (int i = currentYear + 1; i > currentYear - loop; i--)
            {
                list.Add(i);
            }

            return list;
        }

        public static List<int> Monthes()
        {
            List<int> list = new List<int>();

            for (int i = 1; i < 13; i++)
            {
                list.Add(i);
            }

            return list;
        }

        public static List<int> Days(int year,int month)
        {
            List<int> list = new List<int>();
            var days = DateTime.DaysInMonth(year, month);
            for (int i = 1; i < days + 1; i++)
            {
                list.Add(i);
            }
            return list;
        }

        public static List<string> ReadingType()
        {
            List<string> list = new List<string>();
            list.Add("工作需求");
            list.Add("陶冶情操");
            list.Add("消磨时光");
            return list;
        }
    }
}
