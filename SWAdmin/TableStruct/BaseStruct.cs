using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public abstract class BaseStruct
    {
        public Int64 _checksum = 0;
        public long _total = 0;
        public long _offset = -1;
        public abstract void beforeRead();
        public abstract void beforeWrite();
        public abstract void read(SWReader reader);
        public abstract void write(SWWriter writer);

        public void calcChecksum()
        {
            foreach (var field in this.GetType().GetFields())
            {
                if (field.Name.StartsWith("_") || field.Name.EndsWith("_"))
                {
                    continue;
                }
                var val = field.GetValue(this);
                Type valType = val.GetType();

                if (this.appendChecksum(valType, val, this))
                {
                    continue;
                }

                if (valType.IsArray)
                {
                    Array a = val as Array;
                    Type basetype = a.GetType().GetElementType();
                    for (int i = 0; i < a.Length; i++)
                    {
                        object baseele = a.GetValue(i);
                        if (baseele == null)
                        {
                            continue;
                        }
                        this.appendChecksum(baseele.GetType(), baseele, this);
                    }
                }
                else if (valType.FullName.StartsWith("System"))
                {
                    throw new Exception("Unprocessed type.");
                }
            }
        }

        private bool appendChecksum(Type valType, object val, BaseStruct basestruct)
        {
            switch (valType.Name)
            {
                case "UInt32":
                case "Double":
                case "Char":
                case "Byte":
                case "UInt16":
                case "UInt64":
                case "Int16":
                case "Int32":
                case "Int64":
                case "Boolean":
                    basestruct._checksum += Convert.ToInt64(val);
                    return true;
                case "String":
                    byte[] bytes = Encoding.Unicode.GetBytes((string)val);
                    basestruct._checksum += Convert.ToInt64(bytes.Length / 2);
                    for (int i = 0; i < bytes.Length; i++)
                        basestruct._checksum += Convert.ToInt64(bytes[i]);
                    return true;
                case "Single":
                    basestruct._checksum += Convert.ToInt64(Math.Floor(Convert.ToDecimal(val)));
                    return true;
            }
            BaseStruct childBase = val as BaseStruct;
            if (childBase != null)
            {
                childBase.calcChecksum();
                basestruct._checksum += childBase._checksum;
                return true;
            }
            return false;
        }

        public void CreateMD5()
        {
            if (this.GetType().GetField("lsData") == null)
            {
                return;
            }
            this._checksum = (this.GetType().GetField("lsData").GetValue(this) as BaseStruct[]).Sum(data => data._checksum);
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(this._checksum.ToString());
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                SWString md5String = new SWString();
                md5String.zSetValue(sb.ToString().ToLower());
                this.GetType().GetField("md5_").SetValue(this, md5String);
            }
        }

        public String CreateMD5(object data)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(data.ToString());
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public void ResetChecksum()
        {
            this._checksum = 0;
            foreach (FieldInfo fi in this.GetType().GetFields())
            {
                if (fi.FieldType.IsArray)
                {
                    var arr = fi.GetValue(this) as Array;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        BaseStruct basestruct = arr.GetValue(i) as BaseStruct;
                        if (basestruct != null)
                        {
                            basestruct.ResetChecksum();
                        }
                    }
                }
                else
                {
                    BaseStruct basestruct = fi.GetValue(this) as BaseStruct;
                    if (basestruct != null)
                    {
                        basestruct.ResetChecksum();
                    }
                }
            }
        }
    }
}
