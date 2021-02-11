using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDRANKServer : BaseStruct
    {
        public MAZEREWARD_RANKInfo[] lsData;
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

        public class MAZEREWARD_RANKInfo : BaseStruct
        {
            public Byte ID;
            public UInt32 Score_Min;
            public UInt32 Score_Max;
            public Byte Rank;
            public float EXP_Value;
            public float Money_Value;
            public float Share_Point_Value;


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
