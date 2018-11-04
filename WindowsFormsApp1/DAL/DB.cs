using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DBHelp;
using WindowsFormsApp1.Model;

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
                        paramvalue = value == null ? Convert.ToDateTime("1900-01-01 00:00:00") : Convert.ToDateTime(value);
                        break;
                    case "Boolean":
                        paramvalue = value == null ? false : Convert.ToBoolean(value);
                        break;
                    default:
                        paramvalue = value == null ? "" : value.ToString();
                        break;
                }
                parameters.Add(new SqlParameter(p.Name, paramvalue));
            }
            var insertsql = "INSERT INTO {0} SELECT '" + Guid.NewGuid() + "',{1}";
            SqlParameter[] param = parameters.ToArray(); 

            var sql = string.Format(insertsql, type.Name,sb.ToString().TrimEnd(','));

            var result=SQLHelper.ExecuteNonQuery(sql, param);
            return result > 0;
        }

        public static bool Update<T>(Guid id,T model) where T : class, new()
        { return true; }

        public static bool Delete<T>(Guid id) where T : class, new()
        {
            return true;
        }

        public static DataTable Query<T>() where T : class, new()
        {
            var dt = new DataTable();
            return dt;
        }
    }
}
