using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMENDURANCEServer : BaseStruct
    {
        public ITEM_ENDURANCEInfo[] lsData;
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

        public class ITEM_ENDURANCEInfo : BaseStruct
        {
            public UInt32 Endurance_ID;
            public UInt16 Gear_Defence_Rate;
            public float Gear_Defence_Value;
            public UInt16 Gear_Death_Rate;
            public float Gear_Death_Value;
            public UInt16 WP_Attack_Rate;
            public UInt16 SubWP_Attack_Rate;
            public float WP_Attack_Value;
            public float SubWP_Attack_Value;
            public UInt16 WP_Death_Rate;
            public UInt16 SubWP_Death_Rate;
            public float WP_Death_Value;
            public float SubWP_Death_Value;


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
