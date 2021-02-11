using System;

namespace SWAdmin.TableStruct
{
    public class TBINFINITETOWERServer : BaseStruct
    {
        public INFINITE_TOWERInfo[] lsData;
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

        public class INFINITE_TOWERInfo : BaseStruct
        {
            public UInt16 Chapter_ID;
            public Int16 Restriction_Field_ID;
            public UInt16 MazeID_Stage_01;
            public UInt16 MazeID_Stage_02;
            public UInt16 MazeID_Stage_03;
            public UInt16 MazeID_Stage_04;
            public UInt16 MazeID_Stage_05;
            public UInt32 RewardItemID_Stage_01;
            public UInt32 RewardItemID_Stage_02;
            public UInt32 RewardItemID_Stage_03;
            public UInt32 RewardItemID_Stage_04;
            public UInt32 RewardItemID_Stage_05;
            public Byte RewardItemCount_Stage_01;
            public Byte RewardItemCount_Stage_02;
            public Byte RewardItemCount_Stage_03;
            public Byte RewardItemCount_Stage_04;
            public Byte RewardItemCount_Stage_05;
            public UInt32 RewardBP_Stage_01;
            public UInt32 RewardBP_Stage_02;
            public UInt32 RewardBP_Stage_03;
            public UInt32 RewardBP_Stage_04;
            public UInt32 RewardBP_Stage_05;


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
