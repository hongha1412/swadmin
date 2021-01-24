using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Talk_Client : BaseStruct
    {
        public tb_Talk[] lsData;
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

        public class tb_Talk : BaseStruct
        {
            public UInt32 Unknown1;
            public Byte Unknown2;
            public UInt16 Unknown3;
            public UInt32 Unknown4;
            public Byte Unknown5;
            public UInt32 Unknown6;
            public Byte Unknown7;
            public UInt32 Unknown8;
            public UInt32 Unknown9;
            public UInt32 Unknown10;
            public UInt32 Unknown11;
            public UInt32 Unknown12;
            public UInt32 Unknown13;
            public UInt32 Unknown14;
            public UInt32 Unknown15;
            public UInt32 Unknown16;
            public UInt32 Unknown17;
            public UInt32 Unknown18;
            public UInt32 Unknown19;
            public UInt32 Unknown20;
            public UInt32 Unknown21;
            public UInt32 Unknown22;
            public UInt32 Unknown23;
            public UInt32 Unknown24;
            public UInt32 Unknown25;
            public UInt32 Unknown26;
            public UInt32 Unknown27;
            public UInt32 Unknown28;
            public UInt32 Unknown29;
            public UInt32 Unknown30;
            public UInt32 Unknown31;
            public UInt32 Unknown32;
            public UInt32 Unknown33;
            public UInt32 Unknown34;
            public UInt32 Unknown35;
            public UInt32 Unknown36;
            public UInt32 Unknown37;
            public UInt32 Unknown38;
            public UInt32 Unknown39;

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
