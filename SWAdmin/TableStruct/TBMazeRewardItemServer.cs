using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBMazeRewardItemServer : BaseStruct
    {
        public MazeRewardItemInfo[] lsData;
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

        public class MazeRewardItemInfo : BaseStruct
        {
            public UInt32 Maze_ID;
            public UInt16 Mob_Rate;
            public UInt32 Box_ID;
            public UInt32 B_F_ID;
            public UInt32 B_C_ID;
            public UInt32 B_B_ID;
            public UInt32 B_A_ID;
            public UInt32 B_S_ID;
            public UInt32 B_SS_ID;
            public UInt16 B_F_Rate;
            public UInt16 B_C_Rate;
            public UInt16 B_B_Rate;
            public UInt16 B_A_Rate;
            public UInt16 B_S_Rate;
            public UInt16 B_SS_Rate;
            public UInt32 B_F_Min;
            public UInt32 B_C_Min;
            public UInt32 B_B_Min;
            public UInt32 B_A_Min;
            public UInt32 B_S_Min;
            public UInt32 B_SS_Min;
            public UInt32 B_F_Max;
            public UInt32 B_C_Max;
            public UInt32 B_B_Max;
            public UInt32 B_A_Max;
            public UInt32 B_S_Max;
            public UInt32 B_SS_Max;
            public UInt32 Cash_Reward_item_ID;
            public UInt32 Cash_Reward_item_ID_2;
            public Byte Cash_Reward_item_EA_1;
            public Byte Cash_Reward_item_EA_2;

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
