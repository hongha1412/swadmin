using System;

namespace SWAdmin.TableStruct
{
    public class TBPCREWARDSYSTEMMONTHServer : BaseStruct
    {
        public PC_REWARD_SYSTEM_MONTHInfo[] lsData;
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

        public class PC_REWARD_SYSTEM_MONTHInfo : BaseStruct
        {
            public UInt16 Month_Reward_ID;
            public UInt32 Month_Item_ID_1;
            public UInt32 Month_Item_ID_2;
            public UInt32 Month_Item_ID_3;
            public UInt32 Month_Item_ID_4;
            public UInt32 Month_Item_ID_5;
            public UInt32 Month_Item_ID_6;
            public UInt32 Month_Item_ID_7;
            public UInt32 Month_Item_ID_8;
            public UInt32 Month_Item_ID_9;
            public UInt32 Month_Item_ID_10;
            public UInt32 Month_Item_ID_11;
            public UInt32 Month_Item_ID_12;


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
