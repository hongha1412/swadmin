using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Booster_Client : BaseStruct
    {
        public tb_Booster[] lsData;
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

        public class tb_Booster : BaseStruct
        {
            public UInt16 Unknown1;
            public UInt16 Unknown2;
            public Byte Unknown3;
            public Byte Unknown4;
            public Byte Unknown5;
            public Byte Unknown6;
            public Byte Unknown7;
            public Byte Unknown8;
            public Byte Unknown9;
            public Byte Unknown10;
            public Byte Unknown11;
            public Byte Unknown12;
            public Byte Unknown13;
            public Byte Unknown14;
            public Byte Unknown15;
            public Byte Unknown16;
            public Byte Unknown17;
            public Byte Unknown18;
            public Single Unknown19;
            public Single Unknown20;
            public Single Unknown21;
            public Single Unknown22;
            public Single Unknown23;
            public Single Unknown24;
            public Single Unknown25;
            public Single Unknown26;
            public UInt16 Unknown27;
            public UInt16 Unknown28;
            public UInt16 Unknown29;
            public UInt16 Unknown30;
            public UInt16 Unknown31;
            public UInt16 Unknown32;
            public UInt16 Unknown33;
            public UInt16 Unknown34;
            public UInt16 Unknown35;
            public Byte Unknown36;
            public UInt32 Unknown37;

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
