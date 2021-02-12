using System;

namespace SWAdmin.TableStruct
{
    public class TBRANKREWARDServer : BaseStruct
    {
        public RANK_REWARDInfo[] lsData;
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

        public class RANK_REWARDInfo : BaseStruct
        {
            public UInt32 Reward_Index;
            public UInt16 Ranking_Output_ID;
            public UInt32 Ranking_Reward_Division;
            public Byte Max_Ranking_Type;
            public UInt16 Max_Ranking;
            public UInt32 Ranking_Reward_Item_01;
            public UInt32 Ranking_Reward_Item_02;
            public UInt16 Item_Amount_01;
            public UInt16 Item_Amount_02;
            public UInt32 Ranking_Class_Reward_Item_01;
            public UInt32 Ranking_Class_Reward_Item_02;
            public UInt32 Ranking_Class_Reward_Item_03;
            public UInt32 Ranking_Class_Reward_Item_04;
            public UInt32 Ranking_Class_Reward_Item_05;
            public UInt32 Ranking_Class_Reward_Item_06;
            public UInt32 Ranking_Class_Reward_Item_07;
            public UInt32 Ranking_Class_Reward_Item_08;


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
