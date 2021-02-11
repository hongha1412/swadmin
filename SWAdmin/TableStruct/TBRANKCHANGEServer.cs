using System;

namespace SWAdmin.TableStruct
{
    public class TBRANKCHANGEServer : BaseStruct
    {
        public RANK_CHANGEInfo[] lsData;
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

        public class RANK_CHANGEInfo : BaseStruct
        {
            public UInt32 Smelting_ID;
            public Int16 Zeny_rate;
            public Int16 ether_rate;
            public Int16 Rank_Rate_1;
            public Int16 Rank_Rate_2;
            public Int16 Rank_Rate_3;
            public Int16 Rank_Rate_4;
            public Int16 Rank_Rate_5;


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
