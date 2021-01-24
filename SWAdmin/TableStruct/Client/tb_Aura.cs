using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Aura_Client : BaseStruct
    {
        public tb_Aura[] lsData;
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

        public class tb_Aura : BaseStruct
        {
            public UInt16 Unknown1;
            public Byte Unknown2;
            public UInt32 Unknown3;
            public Byte Unknown4;
            public UInt32 Unknown5;
            public UInt32 Unknown6;
            public UInt16 Unknown7;
            public UInt16 Unknown8;
            public UInt16 Unknown9;

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
