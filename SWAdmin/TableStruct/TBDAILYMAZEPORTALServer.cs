using System;

namespace SWAdmin.TableStruct
{
    public class TBDAILYMAZEPORTALServer : BaseStruct
    {
        public DAILYMAZE_PORTALInfo[] lsData;
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

        public class DAILYMAZE_PORTALInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 Monday_Maze_Type;
            public UInt16 Monday_Attribute_Desc;
            public UInt16 Monday_Episode_01;
            public UInt16 Monday_Episode_02;
            public UInt16 Monday_Episode_03;
            public UInt16 Monday_Episode_04;
            public UInt16 Tuesday_Maze_Type;
            public UInt16 Tuesday_Attribute_Desc;
            public UInt16 Tuesday_Episode_01;
            public UInt16 Tuesday_Episode_02;
            public UInt16 Tuesday_Episode_03;
            public UInt16 Tuesday_Episode_04;
            public UInt16 Wednesday_Maze_Type;
            public UInt16 Wednesday_Attribute_Desc;
            public UInt16 Wednesday_Episode_01;
            public UInt16 Wednesday_Episode_02;
            public UInt16 Wednesday_Episode_03;
            public UInt16 Wednesday_Episode_04;
            public UInt16 Thursday_Maze_Type;
            public UInt16 Thursday_Attribute_Desc;
            public UInt16 Thursday_Episode_01;
            public UInt16 Thursday_Episode_02;
            public UInt16 Thursday_Episode_03;
            public UInt16 Thursday_Episode_04;
            public UInt16 Friday_Maze_Type;
            public UInt16 Friday_Attribute_Desc;
            public UInt16 Friday_Episode_01;
            public UInt16 Friday_Episode_02;
            public UInt16 Friday_Episode_03;
            public UInt16 Friday_Episode_04;
            public UInt16 Saturday_Maze_Type;
            public UInt16 Saturday_Attribute_Desc;
            public UInt16 Saturday_Episode_01;
            public UInt16 Saturday_Episode_02;
            public UInt16 Saturday_Episode_03;
            public UInt16 Saturday_Episode_04;
            public UInt16 Sunday_Maze_Type;
            public UInt16 Sunday_Attribute_Desc;
            public UInt16 Sunday_Episode_01;
            public UInt16 Sunday_Episode_02;
            public UInt16 Sunday_Episode_03;
            public UInt16 Sunday_Episode_04;


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
