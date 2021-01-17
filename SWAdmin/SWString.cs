using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin
{
    public class SWString
    {
        public byte[] buff;

        private Encoding _encode;
        public SWString(Encoding code = null)
        {
            if (code == null)
            {
                code = Encoding.Default;
            }
            _encode = code;
        }
        public override string ToString()
        {
            return _encode.GetString(buff);
        }
        public void zSetValue(string value)
        {
            byte[] data = _encode.GetBytes(value);
            if (buff == null)
            {
                buff = data;
                return;
            }
            for (int i = 0; i < buff.Length; i++)
            {
                if (data.Length > i)
                {
                    buff[i] = data[i];
                }
                else
                {
                    buff[i] = 0;
                }
            }

        }
    }
}
