using System;

namespace SWAdmin.TableStruct
{
    public class TBMYROOMGREEDServer : BaseStruct
    {
        public MYROOM_GREEDInfo[] lsData;
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

        public class MYROOM_GREEDInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Greed_X_Axis_Num;
            public UInt32 Greed_Y_Axis_Num;
            public UInt32 Greed_Z_Axis_Num;
            public UInt32 Door_Index;
            public UInt32 Door_Position;
            public UInt32 Door_X_Coordinate;
            public UInt32 Door_Y_Coordinate;
            public UInt32 LeftWindow_Index;
            public UInt32 LeftWindow_Position;
            public UInt32 LeftWindow_X_Coordinate;
            public UInt32 LeftWindow_Y_Coordinate;
            public UInt32 SmallDoor_Index;
            public UInt32 SmallDoor_Position;
            public UInt32 SmallDoor_X_Coordinate;
            public UInt32 SmallDoor_Y_Coordinate;
            public UInt32 RightWindow_Index;
            public UInt32 RightWindow_Position;
            public UInt32 RightWindow_X_Coordinate;
            public UInt32 RightWindow_Y_Coordinate;
            public UInt32 Common_Position_Box_ID;


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
