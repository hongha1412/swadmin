using System;

namespace SWAdmin.TableStruct
{
    public class TBBROACHDATAServer : BaseStruct
    {
        public BROACHDATAInfo[] lsData;
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

        public class BROACHDATAInfo : BaseStruct
        {
            public UInt32 Broach_Index;
            public UInt32 Broach_ID;
            public Byte Broach_Type_Value;
            public Byte Broach_Rank_Value;
            public Byte Broach_Max_Cnt;


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
