using GoogleTranslateFreeApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SWAdmin
{
    public static class DataTableExtension
    {
        public static void FromCsv(this DataTable dtDataTable, string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            string[] headers = sr.ReadLine().Split(',');
            int rIndex = 0;
            while (!sr.EndOfStream)
            {
                string[] rows = sr.ReadLine().Split(',');
                for (int i = 0, j = 0; i < headers.Length; i++)
                {
                    if (string.IsNullOrEmpty(headers[i]) && string.IsNullOrEmpty(rows[i]))
                    {
                        continue;
                    }
                    while (j < dtDataTable.Columns.Count && dtDataTable.Columns[j].ColumnName.StartsWith("_"))
                    {
                        j++;
                    }
                    if (j >= dtDataTable.Columns.Count)
                    {
                        continue;
                    }
                    dtDataTable.Rows[rIndex][j++] = rows[i];
                }
                rIndex++;
            }
        }
        public static void FromTxtTrans(this DataTable dtDataTable, string strFilePath)
        {
            string[] lines = File.ReadAllLines(strFilePath);

            uint id;
            DataRow dr = null;
            int index = 0;
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                if (line.StartsWith("ID="))
                {
                    id = uint.Parse(line.Replace("ID=", ""));
                    DataRow[] arrDr = dtDataTable.Select(dtDataTable.Columns[0].ColumnName + "=" + id);
                    if (arrDr.Length > 0)
                    {
                        dr = arrDr[0];
                        index = 1;
                    }
                    continue;
                }
                while (index < dtDataTable.Columns.Count && dr[index].GetType().Name != "String")
                {
                    index++;
                }
                dr[index] = line.Trim();
                index++;
            }
        }
        public static void ToTxtTrans(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (dtDataTable.Columns[i].ColumnName.StartsWith("_") || (i != 0 && dr[i].GetType().Name != "String"))
                    {
                        continue;
                    }
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        if (i == 0)
                        {
                            sw.Write("ID=");
                        }
                        string value = dr[i].ToString();
                        if (value.Contains('\n'))
                        {
                            value = value.Replace("\n", "<br>");
                        }
                        sw.Write(value);
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(sw.NewLine);
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
        public static void ToTxtPlain(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (dtDataTable.Columns[i].ColumnName.StartsWith("_"))
                    {
                        continue;
                    }
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains('\n'))
                        {
                            value = value.Replace("\n", "<br>");
                        }
                        sw.Write(value);
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write("\t");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
        public static void ToCSV(this DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                if (dtDataTable.Columns[i].ColumnName.StartsWith("_"))
                {
                    continue;
                }
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (dtDataTable.Columns[i].ColumnName.StartsWith("_"))
                    {
                        continue;
                    }
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains('\n'))
                        {
                            value = value.Replace("\n", "<br>");
                        }
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                        }
                        sw.Write(value);
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }
    }
    public static class ObjectExtensions
    {
        public static T ToObject<T>(this IDictionary<string, object> source)
            where T : class, new()
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();

            foreach (var item in source)
            {
                someObjectType
                         .GetProperty(item.Key)
                         .SetValue(someObject, item.Value, null);
            }

            return someObject;
        }

        public static IDictionary<string, object> AsDictionary(this object source, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
        {
            return source.GetType().GetFields(bindingAttr).ToDictionary
            (
                propInfo => propInfo.Name,
                propInfo => propInfo.GetValue(source)
            );

        }

        public static DataTable ToDataTable<T>(this IList<T> data, Type type)
        {
            FieldInfo[] fields = type.GetFields();
            DataTable table = new DataTable();
            for (int i = 0; i < fields.Length; i++)
            {
                FieldInfo fi = fields[i];
                table.Columns.Add(fi.Name, fi.FieldType);
            }
            object[] values = new object[fields.Length];
            foreach (T item in data)
            {
                if (item == null)
                {
                    continue;
                }
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = fields[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
