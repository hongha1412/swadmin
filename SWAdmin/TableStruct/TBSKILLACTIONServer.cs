using System;

namespace SWAdmin.TableStruct
{
    public class TBSKILLACTIONServer : BaseStruct
    {
        public SKILL_ACTIONInfo[] lsData;
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

        public class SKILL_ACTIONInfo : BaseStruct
        {
            public UInt16 Class_Index;
            public UInt32 Skill_ID_01;
            public UInt32 Skill_ID_02;
            public UInt32 Skill_ID_03;
            public UInt32 Skill_ID_04;
            public UInt32 Skill_ID_05;
            public UInt32 Skill_ID_06;
            public UInt32 Skill_ID_07;
            public UInt32 Skill_ID_08;
            public UInt32 Skill_ID_09;


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
