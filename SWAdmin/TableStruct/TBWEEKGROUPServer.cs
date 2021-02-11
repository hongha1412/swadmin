using System;

namespace SWAdmin.TableStruct
{
    public class TBWEEKGROUPServer : BaseStruct
    {
        public WEEK_GROUPInfo[] lsData;
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

        public class WEEK_GROUPInfo : BaseStruct
        {
            public Byte mission_group;
            public Byte Check_Mission_Type;
            public Byte Event_Type;
            public UInt16 Event_Start_Year;
            public Byte Event_Start_Month;
            public Byte Event_Start_Day;
            public UInt16 Event_End_Year;
            public Byte Event_End_Month;
            public Byte Event_End_Day;
            public Byte grop_count;
            public UInt32 reward_item_id;
            public UInt16 reward_count;


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
