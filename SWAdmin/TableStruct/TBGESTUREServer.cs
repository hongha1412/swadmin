using System;

namespace SWAdmin.TableStruct
{
    public class TBGESTUREServer : BaseStruct
    {
        public GESTUREInfo[] lsData;
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

        public class GESTUREInfo : BaseStruct
        {
            public UInt16 Gesture_ID;
            public Byte Use_Class;
            public Byte Req_Min_Level;
            public Byte InitialGesture;
            public UInt32 CoolTime;
            public UInt16 CoolTime_Global;
            public Byte Gesture_Type;
            public UInt16 Gesture_Gain_Type;


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
