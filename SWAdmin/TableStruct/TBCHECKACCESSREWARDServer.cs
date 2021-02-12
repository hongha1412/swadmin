using System;

namespace SWAdmin.TableStruct
{
    public class TBCHECKACCESSREWARDServer : BaseStruct
    {
        public CHECK_ACCESS_REWARDInfo[] lsData;
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

        public class CHECK_ACCESS_REWARDInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Check_Attendance_Type;
            public UInt32 Check_Attendance_Day_Time_1;
            public UInt32 Check_Attendance_Day_Time_2;
            public UInt32 Check_Attendance_Day_Time_3;
            public UInt32 Check_Access_Reward_ID_1st;
            public UInt32 Check_Access_Reward_ID_2st;
            public UInt32 Check_Access_Reward_ID_3st;
            public UInt32 Check_Access_Message_1;
            public UInt32 Check_Access_Message_2;
            public UInt32 Check_Access_Message_3;


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
