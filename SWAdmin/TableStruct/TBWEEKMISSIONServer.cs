using System;

namespace SWAdmin.TableStruct
{
    public class TBWEEKMISSIONServer : BaseStruct
    {
        public WEEK_MISSIONInfo[] lsData;
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

        public class WEEK_MISSIONInfo : BaseStruct
        {
            public UInt16 week_mission_id;
            public Byte Mission_Group_ID;
            public Byte mission_type;
            public UInt16 target_id;
            public Byte complete_value;
            public UInt32 reward_item_id_1;
            public UInt32 reward_item_id_2;
            public UInt32 reward_item_id_3;
            public UInt32 reward_count_1;
            public UInt32 reward_count_2;
            public UInt32 reward_count_3;


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
