using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEENTERCOUNTGROUPServer : BaseStruct
    {
        public MAZE_ENTER_COUNT_GROUPInfo[] lsData;
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

        public class MAZE_ENTER_COUNT_GROUPInfo : BaseStruct
        {
            public UInt16 Group_ID;
            public UInt16 Group_Maze_01;
            public UInt16 Group_Maze_02;
            public UInt16 Group_Maze_03;
            public UInt16 Group_Maze_04;
            public UInt16 Group_Maze_05;
            public UInt16 Group_Maze_06;
            public UInt16 Group_Maze_07;
            public UInt16 Group_Maze_08;
            public UInt16 Group_Maze_09;
            public UInt16 Group_Maze_10;


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
