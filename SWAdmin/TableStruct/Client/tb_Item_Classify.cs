using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Item_Classify_Client : BaseStruct
    {
        public tb_Item_Classify[] lsData;
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

        public class tb_Item_Classify : BaseStruct
        {
            public UInt32 Unkown1;
            public Byte Unkown2;
            public UInt16 Unkown3;
            public Byte Unkown4;
            public UInt16 Unkown5;
            public Byte Unkown6;
            public UInt16 Unkown7;
            public Byte Unkown8;
            public UInt16 Unkown9;
            public Byte Unkown10;
            public Byte Unkown11;
            public Byte Unkown12;
            public Byte Unkown13;
            public Byte Unkown14;
            public Byte Unkown15;
            public Byte Unkown16;
            public UInt16 Unkown17;
            public UInt16 Unkown18;
            public UInt16 Unkown19;
            public String Unkown20 = "";
            public String Unkown21 = "";
            public String Unkown22 = "";
            public String Unkown23 = "";
            public Int16 Unkown24;

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
