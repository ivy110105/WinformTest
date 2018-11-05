using System;
using System.Collections.Generic;
using WindowsFormsApp1.DBHelp;

namespace WindowsFormsApp1.BLL
{
    public static class ScheduleAdapter
    {
        public static bool Insert(Model.Schedule model)
        {
            return DAL.DB.Insert<Model.Schedule>(model);
        }

        public static bool Update(Guid id, Model.Schedule model)
        {
            return DAL.DB.Update<Model.Schedule>(id, model);
        }

        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(Guid id)
        {
            return DAL.DB.Delete<Model.Schedule>(id);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryCondition">查询条件（eg: AND Deleted=0）</param>
        /// <param name="notShowDeleted">不显示已删除数据标志（true:不显示   false:显示），默认不显示</param>
        /// <returns></returns>
        public static List<Model.Schedule> Query(string queryCondition = "", bool notShowDeleted = true)
        {
            var dt = DAL.DB.Query<Model.Schedule>(queryCondition, notShowDeleted);
            return SQLHelper.ConvertToModel<Model.Schedule>(dt);
        }
    }
}