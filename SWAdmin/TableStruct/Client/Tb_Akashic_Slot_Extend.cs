using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class Tb_Akashic_Slot_Extend_Client : BaseStruct
    {
        public Tb_Akashic_Slot_Extend[] lsData;
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

        public class Tb_Akashic_Slot_Extend : BaseStruct
        {
            public Byte Unknown1;
            public UInt32 Unknown2;
            public Byte Unknown3;

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
