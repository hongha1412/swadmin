using SWAdmin.TableStruct;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin
{
    public class SWReader
    {
        private BinaryReader zBr;

        public SWReader(string filename)
        {
            zBr = new BinaryReader(File.OpenRead(filename), Encoding.Unicode);
        }
        public uint readBytesToUint(int count)
        {
            var bs = zBr.ReadBytes(count);
            byte[] padded = new byte[sizeof(UInt32)];
            Array.Copy(bs, 0, padded, 0, bs.Length);
            return BitConverter.ToUInt32(padded, 0);
        }
        public int readBytesToInt(int count)
        {
            var bs = zBr.ReadBytes(count);
            byte[] padded = new byte[sizeof(Int32)];
            Array.Copy(bs, 0, padded, 0, bs.Length);
            return BitConverter.ToInt32(padded, 0);
        }
        public int readi()
        {
            return zBr.ReadInt32();
        }
        public byte readb()
        {
            return zBr.ReadByte();
        }
        public uint readuint()
        {
            return zBr.ReadUInt32();
        }
        public string readBytesToString(int n)
        {
            var bs = zBr.ReadBytes(n);
            return string.Join(" ", bs);
        }
        public float readf()
        {
            return zBr.ReadSingle();
        }
        public string readunicode(int n)
        {
            if (n < 1)
            {
                return "";
            }
            var bs = zBr.ReadBytes(n);
            string s = Encoding.Unicode.GetString(bs);
            return s;
        }
        public string readEncoding(int n, Encoding encoding)
        {
            if (n < 1)
            {
                return "";
            }
            var bs = zBr.ReadBytes(n);
            string s = encoding.GetString(bs);
            return s;
        }
        public byte[] readbs(int n)
        {
            return zBr.ReadBytes(n);
        }

        public short reads()
        {
            return zBr.ReadInt16();
        }

        public void seek(long pos)
        {
            zBr.BaseStream.Position = pos;
        }
        public void close()
        {
            zBr.Close();
        }
        public object readObject(object readobj, string extrname = null)
        {
            Type type = readobj.GetType();
            switch (type.Name)
            {
                case "Double":
                    return zBr.ReadDouble();
                case "Char":
                    return zBr.ReadChar();
                case "UInt16":
                    return zBr.ReadUInt16();
                case "UInt32":
                    return zBr.ReadUInt32();
                case "UInt64":
                    return zBr.ReadUInt64();
                case "Int16":
                    return zBr.ReadInt16();
                case "Int32":
                    return zBr.ReadInt32();
                case "Int64":
                    return zBr.ReadInt64();
                case "Byte":
                    return zBr.ReadByte();
                case "Single":
                    return zBr.ReadSingle();
                case "Boolean":
                    return zBr.ReadBoolean();
                case "String":
                    return this.ReadString();
            }
            BaseStruct se = readobj as BaseStruct;
            if (se != null)
            {
                se._offset = zBr.BaseStream.Position;
                if (se._total <= 0)
                {
                    se._total = zBr.BaseStream.Length;
                }
                se.beforeRead();
            }
            if (type.IsArray)
            {
                Array a = readobj as Array;
                Type basetype = a.GetType().GetElementType();
                for (int i = 0; i < a.Length; i++)
                {
                    object baseele = a.GetValue(i);
                    if (baseele == null)
                    {
                        if (basetype.Name == "String")
                        {
                            baseele = "";
                        }
                        else
                        {
                            baseele = Activator.CreateInstance(basetype);
                        }
                    }
                    a.SetValue(readObject(baseele, extrname), i);
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
                    uint size;
                    if (item.FieldType.GetElementType().BaseType == typeof(BaseStruct))
                    {
                        size = zBr.ReadUInt32();
                    }
                    else
                    {
                        size = zBr.ReadUInt16();
                    }
                    item.SetValue(readobj, Array.CreateInstance(item.FieldType.GetElementType(), size));
                }
                object val = item.GetValue(readobj);
                item.SetValue(readobj, readObject(val, item.Name));
            }

            if (se != null)
            {
                se.read(this);
            }
            return readobj;
        }
        public T readt<T>() where T : class
        {
            Type type = typeof(T);
            T o = Activator.CreateInstance<T>();
            readObject(o);
            return o;
        }
        private string GetVariableName<T>(Expression<Func<T>> expr)
        {
            var body = (MemberExpression)expr.Body;

            return body.Member.Name;
        }
        public string ReadString()
        {
            ushort bnum = zBr.ReadUInt16();
            return Encoding.Unicode.GetString(zBr.ReadBytes(bnum * 2));
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
