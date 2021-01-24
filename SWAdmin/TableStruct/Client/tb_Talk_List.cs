using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Talk_List_Client : BaseStruct
    {
        public tb_Talk_List[] lsData;
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

        public class tb_Talk_List : BaseStruct
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
            public UInt16 Unknown10;
            public UInt16 Unknown11;
            public UInt16 Unknown12;
            public UInt16 Unknown13;
            public UInt16 Unknown14;
            public UInt16 Unknown15;
            public UInt16 Unknown16;
            public UInt16 Unknown17;
            public UInt16 Unknown18;
            public UInt16 Unknown19;
            public UInt16 Unknown20;
            public UInt16 Unknown21;
            public UInt16 Unknown22;
            public UInt16 Unknown23;
            public UInt16 Unknown24;
            public UInt16 Unknown25;
            public UInt16 Unknown26;

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
