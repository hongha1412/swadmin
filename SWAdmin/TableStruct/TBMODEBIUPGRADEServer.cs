using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEBIUPGRADEServer : BaseStruct
    {
        public MODE_BI_UPGRADEInfo[] lsData;
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

        public class MODE_BI_UPGRADEInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Upgrade_Class;
            public Byte Upgrade_Skill_Fix_Type;
            public UInt32 Upgrade_Type;
            public UInt32 Upgrade_Value;
            public UInt32 Upgrade_Cost_Item;
            public UInt32 Upgrade_Cost;


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
