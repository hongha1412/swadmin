using System;

namespace SWAdmin.TableStruct
{
    public class TBEVENTCONDITIONServer : BaseStruct
    {
        public EVENT_CONDITIONInfo[] lsData;
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

        public class EVENT_CONDITIONInfo : BaseStruct
        {
            public UInt32 Event_Condition_ID;
            public Byte Condition_Type;
            public Byte Target_Type;
            public UInt32 Target_ID;
            public UInt32 Finish_Count;


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
