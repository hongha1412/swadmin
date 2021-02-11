using System;

namespace SWAdmin.TableStruct
{
    public class TBRANKREWARDTOTALPOINTServer : BaseStruct
    {
        public RANK_REWARD_TOTALPOINTInfo[] lsData;
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

        public class RANK_REWARD_TOTALPOINTInfo : BaseStruct
        {
            public UInt16 Reward_Index;
            public Byte Ranking_Output_ID;
            public Byte Ranking_Reward_Division;
            public Byte Max_Ranking_Type;
            public UInt16 Max_Ranking;
            public UInt32 Ranking_Point_Value;


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
