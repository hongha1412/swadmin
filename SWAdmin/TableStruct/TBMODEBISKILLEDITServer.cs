using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEBISKILLEDITServer : BaseStruct
    {
        public MODE_BI_SKILL_EDITInfo[] lsData;
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

        public class MODE_BI_SKILL_EDITInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 BI_Skill_Cooltime;


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
