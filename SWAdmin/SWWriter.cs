using SWAdmin.TableStruct;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin
{
    public class SWWriter
    {
        public BinaryWriter zBr { get; private set; }

        public long POS { get { return zBr.BaseStream.Position; } }
        public SWWriter(string filename)
        {
            zBr = new BinaryWriter(File.Open(filename, FileMode.Create));
        }
        public void seek(long pos)
        {
            zBr.BaseStream.Position = pos;
        }

        public void flush()
        {
            zBr.Flush();
            this.close();
        }
        public void writeObject(object writeobj, string extrname = null)
        {
            Type type = writeobj.GetType();
            switch (type.Name)
            {
                case "Double":
                    zBr.Write((double)writeobj);
                    return;
                case "UInt16":
                    zBr.Write((ushort)writeobj);
                    return;
                case "UInt32":
                    zBr.Write((uint)writeobj);
                    return;
                case "UInt64":
                    zBr.Write((ulong)writeobj);
                    return;
                case "Int16":
                    zBr.Write((short)writeobj);
                    return;
                case "Int32":
                    zBr.Write((int)writeobj);
                    return;
                case "Int64":
                    zBr.Write((long)writeobj);
                    return;
                case "Byte":
                    zBr.Write((byte)writeobj);
                    return;
                case "Single":
                    zBr.Write((float)writeobj);
                    return;
                case "Boolean":
                    zBr.Write((bool)writeobj);
                    return;
                case "String":
                    this.WriteString(writeobj, extrname);
                    return;
            }
            BaseStruct se = writeobj as BaseStruct;
            if (se != null)
            {
                se.beforeWrite();
            }
            if (type.IsArray)
            {
                Array a = writeobj as Array;
                Type basetype = a.GetType().GetElementType();
                for (int i = 0; i < a.Length; i++)
                {
                    object v = a.GetValue(i);
                    if (v == null)
                    {
                        v = Activator.CreateInstance(basetype);
                    }
                    writeObject(v, extrname);
                }
            }
            else if (type.FullName.StartsWith("System"))
            {
                throw new Exception("Unprocessed type.");
            }

            var mens = type.GetFields();
            foreach (var item in mens)
            {
                if (item.Name.StartsWith("_"))
                {
                    continue;
                }
                if (item.FieldType.IsArray)
                {
                    if (item.FieldType.GetElementType().BaseType == typeof(BaseStruct))
                    {
                        zBr.Write((item.GetValue(writeobj) as Array).Length);
                    }
                    else
                    {
                        zBr.Write((ushort)(item.GetValue(writeobj) as Array).Length);
                    }
                }
                object val = item.GetValue(writeobj);
                writeObject(val, item.Name);
            }

            if (se != null)
            {
                se.write(this);
            }
        }
        public void close()
        {
            zBr.Close();
        }

        public void WriteString(object writeobj, string extrname = null)
        {
            byte[] ss = Encoding.Unicode.GetBytes((string)writeobj);
            if (extrname != null)
            {
                string[] num = extrname.Split(new char[] { '_' });
                if (int.TryParse(num[num.Length - 1], out int bnum))
                {
                    byte[] buff = new byte[bnum];
                    for (int i = 0; i < bnum; i++)
                    {
                        if (i >= ss.Length)
                        {
                            break;
                        }
                        buff[i] = ss[i];
                    }
                    zBr.Write(buff);
                    return;
                }
            }
            zBr.Write((ushort)(ss.Length / 2));
            zBr.Write(ss);
        }
        public bool IsList(object o)
        {
            if (o == null) return false;
            return o is IList &&
                   o.GetType().IsGenericType &&
                   o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
        }
    }
}
