using System;

namespace SWAdmin.TableStruct
{
    public class TBWORLDEVENTServer : BaseStruct
    {
        public WORLD_EVENTInfo[] lsData;
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

        public class WORLD_EVENTInfo : BaseStruct
        {
            public UInt32 event_ID;
            public Byte event_activation;
            public String event_start_date_String = "";
            public String event_end_date_String = "";
            public String event_name_String = "";
            public UInt32 event_item_ID;
            public UInt32 event_item_amount_max;
            public UInt32 event_daily_reward_item_ID;
            public UInt16 event_daily_reward_item_amount;


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
