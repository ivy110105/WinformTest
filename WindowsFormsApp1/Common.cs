using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void OpenNewForm(Form newform)
        {
            if (newform.ShowDialog() == DialogResult.OK)//对话框返回值为ok时运行
            {
                
            }
        }

        public static List<string> RepeatType()
        {
            List<string> list = new List<string>();
            list.Add("days");
            list.Add("weeks");
            list.Add("months");
            list.Add("years");
            return list;
        }
    }
}
