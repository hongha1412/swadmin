using System;

namespace SWAdmin.TableStruct
{
    public class TBCHECKATTENDANCEREWARDServer : BaseStruct
    {
        public CHECK_ATTENDANCE_REWARDInfo[] lsData;
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

        public class CHECK_ATTENDANCE_REWARDInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Link_ID;
            public UInt32 Attendance_Reward_Gold;
            public UInt32 Attendance_Reward_Ether;
            public UInt32 Attendance_Item_Reward_ID_1;
            public UInt32 Attendance_Item_Reward_ID_2;
            public UInt32 Attendance_Item_Reward_ID_3;
            public UInt32 Attendance_Item_Reward_ID_4;
            public UInt32 Attendance_Item_Reward_ID_5;
            public UInt32 Attendance_Item_Reward_Num_1;
            public UInt32 Attendance_Item_Reward_Num_2;
            public UInt32 Attendance_Item_Reward_Num_3;
            public UInt32 Attendance_Item_Reward_Num_4;
            public UInt32 Attendance_Item_Reward_Num_5;


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
