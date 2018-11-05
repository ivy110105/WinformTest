using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using WindowsFormsApp1.DBHelp;

namespace WindowsFormsApp1.DAL
{
    public class DB
    {
        public static bool Insert<T>(T model) where T : class, new()
        {
            Type type = model.GetType();
            PropertyInfo[] pArray = type.GetProperties();
            StringBuilder sb = new StringBuilder();
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var p in pArray)
            {
                object value = type.GetProperty(p.Name).GetValue(model, null);
                object paramvalue;
                sb.Append("@" + p.Name + ",");
                switch (p.PropertyType.Name)
                {
                    case "String":
                        paramvalue = value == null ? "" : value.ToString();
                        break;
                    case "Int32":
                        paramvalue = value == null ? 0 : Convert.ToInt32(value);
                        break;
                    case "DateTime":
                        paramvalue = value == null ? new DateTime?() : Convert.ToDateTime(value);
                        break;
                    case "Boolean":
                        paramvalue = value == null ? false : Convert.ToBoolean(value);
                        break;
                    case "System.Guid":
                        paramvalue = value == null ? Guid.Empty : Guid.Parse(value.ToString());
                        break;
                    default:
                        paramvalue = value == null ? "" : value.ToString();
                        break;
                }
                parameters.Add(new SqlParameter(p.Name, paramvalue));
            }
            var sql = $"INSERT INTO {type.Name} SELECT {sb.ToString().TrimEnd(',')}";
            SqlParameter[] param = parameters.ToArray(); 

            var result=SQLHelper.ExecuteNonQuery(sql, param);
            return result > 0;
        }

        public static bool Update<T>(Guid id,T model) where T : class, new()
        {
            Type type = model.GetType();
            PropertyInfo[] pArray = type.GetProperties();
            StringBuilder sb = new StringBuilder();
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var p in pArray)
            {
                object value = type.GetProperty(p.Name).GetValue(model, null);
                object paramvalue;
                sb.Append($"{p.Name} = @{p.Name},");
                switch (p.PropertyType.Name)
                {
                    case "String":
                        paramvalue = value == null ? "" : value.ToString();
                        break;
                    case "Int32":
                        paramvalue = value == null ? 0 : Convert.ToInt32(value);
                        break;
                    case "DateTime":
                        paramvalue = value == null ? Convert.ToDateTime("1900-01-01 00:00:00") : Convert.ToDateTime(value);
                        break;
                    case "Boolean":
                        paramvalue = value == null ? false : Convert.ToBoolean(value);
                        break;
                    case "System.Guid":
                        paramvalue = value == null ? Guid.Empty : Guid.Parse(value.ToString());
                        break;
                    default:
                        paramvalue = value == null ? "" : value.ToString();
                        break;
                }
                parameters.Add(new SqlParameter(p.Name, paramvalue));
            }
            var sql = $"UPDATE {type.Name} SET {sb.ToString().TrimEnd(',')} WHERE ID = '{id}'";
            SqlParameter[] param = parameters.ToArray();

            var result = SQLHelper.ExecuteNonQuery(sql, param);
            return result > 0;
        }

        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete<T>(Guid id) where T : class, new()
        {
            Type type = typeof(T);

            var sql = $"UPDATE {type.Name} SET Deleted=1 WHERE ID = '{id}'";

            var result = SQLHelper.ExecuteNonQuery(sql, null);
            return result > 0;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryCondition">查询条件（eg: AND Deleted=0）</param>
        /// <param name="notShowDeleted">不显示已删除数据标志（true:不显示   false:显示），默认不显示</param>
        /// <returns></returns>
        public static DataTable Query<T>(string queryCondition,bool notShowDeleted = true) where T : class, new()
        {
            Type type = typeof(T);
            var sql = $"SELECT * FROM {type.Name} WHERE 1=1 ";
            if (notShowDeleted)
                sql = sql + " AND Deleted=0 ";
            if (!string.IsNullOrWhiteSpace(queryCondition))
            {
                sql = sql + queryCondition;
            }
            
            var dt = SQLHelper.ExecuteDataTable(sql, null);
            return dt;
        }
    }
}
