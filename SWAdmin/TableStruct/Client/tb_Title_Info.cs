using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Title_Info_Client : BaseStruct
    {
        public tb_Title_Info[] lsData;
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

        public class tb_Title_Info : BaseStruct
        {
            public UInt32 Unknown1;
            public UInt32 Unknown2;
            public Byte Unknown3;
            public Byte Unknown4;
            public UInt16 Unknown5;
            public Byte Unknown6;
            public UInt32 Unknown7;
            public Byte Unknown8;
            public Byte Unknown9;
            public Byte Unknown10;
            public Byte Unknown11;
            public Byte Unknown12;
            public Byte Unknown13;
            public UInt16 Unknown14;
            public UInt16 Unknown15;
            public UInt16 Unknown16;
            public UInt16 Unknown17;
            public UInt16 Unknown18;
            public Single Unknown19;
            public Single Unknown20;
            public Single Unknown21;
            public Single Unknown22;
            public Single Unknown23;


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
