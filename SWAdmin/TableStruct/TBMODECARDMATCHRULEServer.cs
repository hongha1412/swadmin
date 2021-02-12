using System;

namespace SWAdmin.TableStruct
{
    public class TBMODECARDMATCHRULEServer : BaseStruct
    {
        public MODE_CARDMATCH_RULEInfo[] lsData;
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

        public class MODE_CARDMATCH_RULEInfo : BaseStruct
        {
            public UInt32 CardMatch_ID;
            public UInt32 Win_Reward;
            public UInt32 Lose_Reward;


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
