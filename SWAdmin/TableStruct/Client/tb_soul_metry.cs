using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_soul_metry_Client : BaseStruct
    {
        public tb_soul_metry[] lsData;
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

        public class tb_soul_metry : BaseStruct
        {
            public UInt16 Unknown1;
            public UInt16 Unknown2;
            public UInt16 Unknown3;
            public UInt16 Unknown4;
            public UInt16 Unknown5;
            public UInt16 Unknown6;
            public UInt16 Unknown7;
            public UInt16 Unknown8;
            public UInt16 Unknown9;
            public UInt32 Unknown10;
            public UInt32 Unknown11;
            public UInt32 Unknown12;
            public UInt32 Unknown13;
            public UInt32 Unknown14;
            public UInt16 Unknown15;
            public UInt16 Unknown16;
            public UInt16 Unknown17;
            public UInt16 Unknown18;
            public UInt16 Unknown19;
            public String Unknown20 = "";
            public String Unknown21 = "";
            public String Unknown22 = "";
            public String Unknown23 = "";
            public String Unknown24 = "";
            public UInt16 Unknown25;
            public UInt16 Unknown26;
            public UInt16 Unknown27;
            public UInt16 Unknown28;
            public UInt16 Unknown29;
            public Byte Unknown30;
            public Byte Unknown31;
            public UInt32 Unknown32;
            public UInt32 Unknown33;
            public Byte Unknown34;
            public Byte Unknown35;

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
