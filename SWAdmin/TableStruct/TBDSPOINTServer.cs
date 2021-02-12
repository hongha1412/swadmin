using System;

namespace SWAdmin.TableStruct
{
    public class TBDSPOINTServer : BaseStruct
    {
        public DS_POINTInfo[] lsData;
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

        public class DS_POINTInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Share_Type;
            public UInt16 DS_Point_ID;
            public Byte Gauge_Type;
            public Byte Clear_Point_1;
            public Byte Clear_Point_2;
            public Byte Clear_Point_3;
            public Byte Clear_Point_4;
            public Byte Clear_Point_5;
            public UInt16 Reward_Value_01;
            public UInt16 Reward_Value_02;
            public UInt16 Reward_Value_03;
            public UInt16 Reward_Value_04;
            public UInt16 Reward_Value_05;
            public Byte Reward_ItemType_01;
            public Byte Reward_ItemType_02;
            public Byte Reward_ItemType_03;
            public Byte Reward_ItemType_04;
            public Byte Reward_ItemType_05;
            public UInt32 Reward_ItemID_01;
            public UInt32 Reward_ItemID_02;
            public UInt32 Reward_ItemID_03;
            public UInt32 Reward_ItemID_04;
            public UInt32 Reward_ItemID_05;
            public Byte Item_Count_01;
            public Byte Item_Count_02;
            public Byte Item_Count_03;
            public Byte Item_Count_04;
            public Byte Item_Count_05;


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
