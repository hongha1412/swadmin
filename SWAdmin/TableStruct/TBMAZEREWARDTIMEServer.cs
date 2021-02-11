using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDTIMEServer : BaseStruct
    {
        public MAZEREWARD_TIMEInfo[] lsData;
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

        public class MAZEREWARD_TIMEInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 Time_Value_Min;
            public UInt16 Time_Value_Max;
            public float ClearTime_Value;


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
