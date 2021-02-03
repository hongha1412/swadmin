using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBDayEventServer : BaseStruct
    {
        public DayEventInfo[] lsData;
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

        public class DayEventInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Event_Count_Min;
            public Byte Event_Count_Max;
            public UInt16 Maze_Select_1;
            public UInt16 Maze_Select_2;
            public UInt16 Maze_Select_3;
            public UInt16 Maze_Select_4;
            public UInt16 Maze_Select_5;
            public UInt16 Maze_Select_6;
            public UInt16 Maze_Select_7;
            public UInt16 Maze_Select_8;
            public UInt16 Maze_Select_9;
            public UInt16 Maze_Select_10;
            public UInt16 Maze_Booster_Group_1;
            public UInt16 Maze_Booster_Group_2;
            public UInt16 Maze_Booster_Group_3;
            public UInt16 Maze_Booster_Group_4;
            public UInt16 Maze_Booster_Group_5;
            public UInt16 Maze_Booster_Group_6;
            public UInt16 Maze_Booster_Group_7;
            public UInt16 Maze_Booster_Group_8;
            public UInt16 Maze_Booster_Group_9;
            public UInt16 Maze_Booster_Group_10;
            public UInt16 Fix_Maze_Select_1;
            public UInt16 Fix_Maze_Select_2;
            public UInt16 Fix_Maze_Select_3;
            public UInt16 Fix_Maze_Select_4;
            public UInt16 Fix_Maze_Booster_Group_1;
            public UInt16 Fix_Maze_Booster_Group_2;
            public UInt16 Fix_Maze_Booster_Group_3;
            public UInt16 Fix_Maze_Booster_Group_4;

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
