using System;

namespace SWAdmin.TableStruct
{
    public class TBHELPERREWARDServer : BaseStruct
    {
        public HELPER_REWARDInfo[] lsData;
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

        public class HELPER_REWARDInfo : BaseStruct
        {
            public Byte ID;
            public Byte Reward_Type;
            public UInt16 Reward_FriendPoint_Value;
            public UInt32 Reward_Item_ID_01;
            public UInt32 Reward_Item_ID_02;
            public UInt32 Reward_Item_ID_03;
            public Byte Reward_Item_Count_01;
            public Byte Reward_Item_Count_02;
            public Byte Reward_Item_Count_03;


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
