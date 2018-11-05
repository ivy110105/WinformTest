using System.Data.SqlClient;
using System.Data;
using System.Configuration;//Configuration表面配置，组态，构造
using System.Collections.Generic;
using System;
using System.Reflection;

namespace WindowsFormsApp1.DBHelp
{
    public class SQLHelper
    {
        public static string GetSqlConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        }
        //适合增删改操作，返回影响条数
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GetSqlConnectionString()))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    conn.Open();
                    comm.CommandText = sql;
                    if (parameters != null)
                        comm.Parameters.AddRange(parameters);
                    return comm.ExecuteNonQuery();
                }
            }
        }
        //查询操作，返回查询结果中的第一行第一列的值
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GetSqlConnectionString()))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    conn.Open();
                    comm.CommandText = sql;
                    if (parameters != null)
                        comm.Parameters.AddRange(parameters);
                    return comm.ExecuteScalar();
                }
            }
        }
        //Adapter调整，查询操作，返回DataTable
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, GetSqlConnectionString()))
            {
                DataTable dt = new DataTable();
                if (parameters != null)
                    adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.Fill(dt);
                return dt;
            }
        }

        public static SqlDataReader ExecuteReader(string sqlText, params SqlParameter[] parameters)
        {
            //SqlDataReader要求，它读取数据的时候有，它独占它的SqlConnection对象，而且SqlConnection必须是Open状态
            SqlConnection conn = new SqlConnection(GetSqlConnectionString());//不要释放连接，因为后面还需要连接打开状态
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = sqlText;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            //CommandBehavior.CloseConnection当SqlDataReader释放的时候，顺便把SqlConnection对象也释放掉
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 将DataTable转换成List<实体类>方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static List<T> ConvertToModel<T>(DataTable dt) where T : class, new()
        {
            // 定义集合    
            var ts = new List<T>();

            // 获得此模型的类型   
            Type type = typeof(T);
            string tempName = "";

            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                // 获得此模型的公共属性      
                PropertyInfo[] propertys = t.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    tempName = pi.Name;  // 检查DataTable是否包含此列    

                    if (dt.Columns.Contains(tempName))
                    {
                        // 判断此属性是否有Setter      
                        if (!pi.CanWrite) continue;

                        object value = dr[tempName];
                        if (value != DBNull.Value)
                            pi.SetValue(t, value, null);
                    }
                }
                ts.Add(t);
            }
            return ts;
        }
    }

    //public class ModelConvertHelper<T> where T : class, new()
    //{
    //    /// <summary>
    //    /// 将DataTable转换成List<实体类>方法
    //    /// </summary>
    //    /// <typeparam name="T"></typeparam>
    //    public static List<T> ConvertToModel(DataTable dt)
    //    {
    //        // 定义集合    
    //        var ts = new List<T>();

    //        // 获得此模型的类型   
    //        Type type = typeof(T);
    //        string tempName = "";

    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            T t = new T();
    //            // 获得此模型的公共属性      
    //            PropertyInfo[] propertys = t.GetType().GetProperties();
    //            foreach (PropertyInfo pi in propertys)
    //            {
    //                tempName = pi.Name;  // 检查DataTable是否包含此列    

    //                if (dt.Columns.Contains(tempName))
    //                {
    //                    // 判断此属性是否有Setter      
    //                    if (!pi.CanWrite) continue;

    //                    object value = dr[tempName];
    //                    if (value != DBNull.Value)
    //                        pi.SetValue(t, value, null);
    //                }
    //            }
    //            ts.Add(t);
    //        }
    //        return ts;
    //    }
    //}
}
