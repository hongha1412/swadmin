using System;

namespace SWAdmin.TableStruct
{
    public class TBAKASHICSLOTEXTENDServer : BaseStruct
    {
        public AKASHIC_SLOT_EXTENDInfo[] lsData;
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

        public class AKASHIC_SLOT_EXTENDInfo : BaseStruct
        {
            public Byte Extend_Index;
            public UInt32 Extend_Akashic_Need_Item_ID;
            public Byte Extend_Akashic_Need_Item_Num;


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
