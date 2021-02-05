using System;

namespace SWAdmin.TableStruct
{
    public class TBMODECARDMATCHCARDServer : BaseStruct
    {
        public MODE_CARDMATCH_CARDInfo[] lsData;
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

        public class MODE_CARDMATCH_CARDInfo : BaseStruct
        {
            public UInt32 Card_ID;


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
