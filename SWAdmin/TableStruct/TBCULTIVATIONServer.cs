using System;

namespace SWAdmin.TableStruct
{
    public class TBCULTIVATIONServer : BaseStruct
    {
        public CULTIVATIONInfo[] lsData;
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

        public class CULTIVATIONInfo : BaseStruct
        {
            public UInt32 Seed_Item_ID;
            public UInt32 Crops_Item_ID;
            public UInt32 Crops_Item_Num;
            public UInt32 Cultivation_Bonus_Rate;
            public UInt32 Crops_Bonus_Item_Num;
            public UInt32 Cultivation_Time;
            public UInt32 Cultivation_Boost_Time;
            public UInt32 Wilt_Item_ID;
            public UInt32 Wilt_Item_ID_Num;
            public UInt32 Decay_Item_ID;
            public UInt32 Decay_Item_ID_Num;
            public UInt32 Auto_Usage_Item;


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
