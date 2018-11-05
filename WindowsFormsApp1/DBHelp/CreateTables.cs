using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DBHelp
{
    public class CreateTables
    {
        /// <summary>
        /// 根据实体类自动创建表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void Create<T>() where T : class, new()
        {
            string tableModel = @"
            if not exists (select * from sysobjects where xtype='U' and name='{0}')
            begin
                    CREATE TABLE {0} (                        
                        {1}
                    )
            end;";//--ID uniqueidentifier primary key,
            Type type = typeof(T);
            PropertyInfo[] pArray = type.GetProperties();
            StringBuilder sb = new StringBuilder();
            foreach (var p in pArray)
            {
                var len = "";
                var attr = p.GetCustomAttribute<DataFieldAttribute>();
                if (attr != null)
                    len = attr.FieldType;

                sb.Append(p.Name);
                var pt = p.PropertyType.ToString();
                switch (p.PropertyType.ToString())
                {
                    case "System.Int32":
                        sb.Append(" INTEGER");
                        break;
                    case "System.Boolean":
                        sb.Append(" BIT");
                        break;
                    case "System.DateTime":
                        sb.Append(" DATETIME");
                        break;
                    case "System.Double":
                        sb.Append(" DOUBLE");
                        break;
                    case "System.Guid":
                        sb.Append(" uniqueidentifier");
                        if (p.Name == "ID") sb.Append(" primary key");
                        break;
                    default:
                        sb.Append(" VARCHAR");
                        sb.Append("(" + len + ")");
                        break;
                }
                sb.Append(",");
            }
            var sql = string.Format(tableModel, type.Name, sb.ToString().TrimEnd(','));
            SQLHelper.ExecuteNonQuery(sql, null);
        }
    }
}
