using System;

namespace SWAdmin.TableStruct
{
    public class TBSKILLOPTIONServer : BaseStruct
    {
        public SKILL_OPTIONInfo[] lsData;
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

        public class SKILL_OPTIONInfo : BaseStruct
        {
            public UInt32 Skill_Option_ID;
            public UInt32 Skill_Group_ID;
            public Int16 Skill_Option_Flag;


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
