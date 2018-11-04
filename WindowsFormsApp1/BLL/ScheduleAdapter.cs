using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    public static class ScheduleAdapter
    {
        public static bool Insert(Model.Schedule model)
        {
            return DAL.DB.Insert<Model.Schedule>(model);
        }
    }
}
