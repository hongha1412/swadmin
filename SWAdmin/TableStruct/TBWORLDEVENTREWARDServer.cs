using System;

namespace SWAdmin.TableStruct
{
    public class TBWORLDEVENTREWARDServer : BaseStruct
    {
        public WORLD_EVENT_REWARDInfo[] lsData;
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

        public class WORLD_EVENT_REWARDInfo : BaseStruct
        {
            public UInt32 world_reward_ID;
            public Byte world_reward_type;
            public UInt16 event_item_percentile_min;
            public UInt16 event_item_percentile_max;
            public Byte event_reward_type;
            public UInt32 event_reward_value;
            public UInt16 event_reward_item_amount;


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
