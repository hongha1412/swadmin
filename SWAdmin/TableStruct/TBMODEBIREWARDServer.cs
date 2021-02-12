using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEBIREWARDServer : BaseStruct
    {
        public MODE_BI_REWARDInfo[] lsData;
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

        public class MODE_BI_REWARDInfo : BaseStruct
        {
            public Byte ID;
            public UInt16 BI_Reward_Coin_Value;
            public UInt32 BI_Reward_Item;
            public UInt32 BI_Reward_Item_Value;


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
