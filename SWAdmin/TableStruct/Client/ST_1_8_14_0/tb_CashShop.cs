using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct.Client.ST_1_8_14_0
{
    public class tb_CashShop_Client : BaseStruct
    {
        public tb_CashShop[] lsData;
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

        public class tb_CashShop : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt16 Unkown2;
            public UInt16 Unkown3;
            public Byte Unkown4;
            public UInt32 Unkown5;
            public Byte Unkown6;
            public Byte Unkown7;
            public Byte Unkown8;
            public UInt32 Unkown9;
            public Byte Unkown10;
            public String Unkown11 = "";
            public String Unkown12 = "";
            public Byte Unkown13;
            public UInt16 Unkown14;
            public Byte Unkown15;
            public UInt16 Unkown16;
            public UInt16 Unkown17;
            public Byte Unkown18;
            public Byte Unkown19;
            public Byte Unkown20;
            public Byte Unkown21;
            public Byte Unkown22;
            public String Unkown23 = "";


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