using System;

namespace SWAdmin.TableStruct
{
    public class TBQUESTREWARDServer : BaseStruct
    {
        public QUEST_REWARDInfo[] lsData;
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

        public class QUEST_REWARDInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt32 Item_PC_A;
            public UInt32 Item_PC_B;
            public UInt32 Item_PC_C;
            public UInt32 Item_PC_D;
            public UInt32 Item_PC_E;
            public UInt32 Item_PC_F;
            public UInt32 Item_PC_G;
            public UInt32 Item_PC_H;


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
