using System;

namespace SWAdmin.TableStruct
{
    public class TBCHECKATTENDANCEINFOServer : BaseStruct
    {
        public CHECK_ATTENDANCE_INFOInfo[] lsData;
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

        public class CHECK_ATTENDANCE_INFOInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Check_Attendance_Type;
            public UInt32 Check_Attendance_Num;


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
