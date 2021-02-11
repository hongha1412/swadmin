using DevExpress.XtraSplashScreen;
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
using System.Windows.Forms;

namespace SWAdmin
{
    public static class DataTableExtension
    {
        public static void FromRes(this DataTable dtDataTable, DataTable other, int cIndex, SplashScreenManager splashScreenManager)
        {
            for (int rIndex = 0; rIndex < other.Rows.Count; rIndex++)
            {
                DataRow[] arrDr = dtDataTable.Select(dtDataTable.Columns[0].ColumnName + "=" + other.Rows[rIndex][0]);
                if (arrDr.Length > 0)
                {
                    if (cIndex < 0 || cIndex >= dtDataTable.Columns.Count)
                    {
                        for (int i = 0; i < other.Columns.Count; i++)
                        {
                            arrDr[0][i] = other.Rows[rIndex][i];
                        }
                    }
                    else
                    {
                        arrDr[0][cIndex] = other.Rows[rIndex][cIndex];
                    }
                }
                splashScreenManager.SetWaitFormDescription((rIndex + 1) + "/" + other.Rows.Count);
                Application.DoEvents();
            }
        }
        public static void FromCsv(this DataTable dtDataTable, string strFilePath, SplashScreenManager splashScreenManager)
        {
            StreamReader sr = new StreamReader(strFilePath);
            string[] headers = sr.ReadLine().Split('\t');
            int count = File.ReadLines(strFilePath).Count();
            int lIndex = 1;
            Dictionary<string, List<int>> dataMap = new Dictionary<string, List<int>>();
            string idValue;
            for (int i = 0; i < dtDataTable.Rows.Count; i++)
            {
                idValue = dtDataTable.Rows[i][0].ToString();
                if (!dataMap.ContainsKey(idValue))
                {
                    dataMap.Add(idValue, new List<int>());
                }
                dataMap[idValue].Add(i);
            }

            while (!sr.EndOfStream)
            {
                string[] rows = sr.ReadLine().Split('\t');
                for (int i = 0, j = 0; i < headers.Length; i++)
                {
                    if (string.IsNullOrEmpty(headers[i]) && string.IsNullOrEmpty(rows[i]))
                    {
                        continue;
                    }
                    if (!dataMap.ContainsKey(rows[0]))
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
                    foreach (int rIndex in dataMap[rows[0]])
                    {
                        dtDataTable.Rows[rIndex][j++] = rows[i];
                    }
                }
                splashScreenManager.SetWaitFormDescription(lIndex++ + "/" + count);
                Application.DoEvents();
            }
        }
        public static void FromTxtTrans(this DataTable dtDataTable, string strFilePath, SplashScreenManager splashScreenManager)
        {
            string[] lines = File.ReadAllLines(strFilePath);

            uint id;
            DataRow dr = null;
            int index = 0;
            for (int lIndex = 0; lIndex < lines.Length; lIndex++)
            {
                if (string.IsNullOrEmpty(lines[lIndex]))
                {
                    continue;
                }
                if (lines[lIndex].StartsWith("ID="))
                {
                    id = uint.Parse(lines[lIndex].Replace("ID=", ""));
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
                dr[index] = lines[lIndex].Trim();
                index++;
                splashScreenManager.SetWaitFormDescription((lIndex + 1) + "/" + lines.Length);
                Application.DoEvents();
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
                    sw.Write("\t");
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
                            //value = value.Replace("\n", "<br>");
                            value = Regex.Replace(value, "(\n)", "<br>");
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
