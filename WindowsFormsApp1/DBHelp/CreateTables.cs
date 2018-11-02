using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DBHelp
{
    public class CreateTables
    {
        public static void Create<T>() where T : class, new()
        {
            string tableModel = @"
            if not exists (select * from sysobjects where xtype='U' and name='{0}')
            begin
                    CREATE TABLE {0} (
                        ID uniqueidentifier primary key,
                        {1}
                    )
            end;";
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
