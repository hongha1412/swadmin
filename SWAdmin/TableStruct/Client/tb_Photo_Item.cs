using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Photo_Item_Client : BaseStruct
    {
        public tb_Photo_Item[] lsData;
        public SWString md5_ = new SWString();

        public override void beforeRead()
        {
        }

        public override void beforeWrite()
        {
        }

        public override void read(SWReader reader)
        {
        }

        public override void write(SWWriter writer)
        {
        }

        public class tb_Photo_Item : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public UInt16 Unkown3;
            public String Unkown4 = "";
            public String Unkown5 = "";
            public String Unkown6 = "";
            public String Unkown7 = "";
            public String Unkown8 = "";
            public String Unkown9 = "";
            public String Unkown10 = "";
            public String Unkown11 = "";
            public String Unkown12 = "";
            public String Unkown13 = "";
            public Byte Unkown14;
            public Byte Unkown15;

            public override void beforeRead()
            {
            }

            public override void beforeWrite()
            {
            }

            public override void read(SWReader reader)
            {
            }

            public override void write(SWWriter writer)
            {
            }
        }
    }
}
