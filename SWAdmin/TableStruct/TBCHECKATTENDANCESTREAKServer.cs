using System;

namespace SWAdmin.TableStruct
{
    public class TBCHECKATTENDANCESTREAKServer : BaseStruct
    {
        public CHECK_ATTENDANCE_STREAKInfo[] lsData;
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

        public class CHECK_ATTENDANCE_STREAKInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Check_Attendance_Type;
            public UInt32 Attendance_Streak_Reward_1day;
            public UInt32 Attendance_Streak_Reward_2day;
            public UInt32 Attendance_Streak_Reward_3day;
            public UInt32 Attendance_Streak_Reward_1day_Value;
            public UInt32 Attendance_Streak_Reward_2day_Value;
            public UInt32 Attendance_Streak_Reward_3day_Value;


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
