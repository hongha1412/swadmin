using System;

namespace SWAdmin.TableStruct
{
    public class TBRANKINFOServer : BaseStruct
    {
        public RANK_INFOInfo[] lsData;
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

        public class RANK_INFOInfo : BaseStruct
        {
            public UInt16 Ranking_Index;
            public Byte Ranking_Category;
            public Byte Ranking_Total_Type;
            public Byte Ranking_Total_Class_Type;
            public UInt16 Ranking_Visible;
            public Byte Ranking_Reward_Receive;
            public UInt32 Ranking_Reward;
            public UInt32 Ranking_Maze;


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
