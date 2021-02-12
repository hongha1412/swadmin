using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEBICLASSSTARTSKILLServer : BaseStruct
    {
        public MODE_BI_CLASS_STARTSKILLInfo[] lsData;
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

        public class MODE_BI_CLASS_STARTSKILLInfo : BaseStruct
        {
            public Byte ID;
            public UInt32 BI_StartSkill_Active;
            public UInt32 BI_StartSkill_01;
            public UInt32 BI_StartSkill_02;
            public UInt32 BI_StartSkill_03;
            public UInt32 BI_StartSkill_04;
            public UInt32 BI_StartSkill_05;
            public UInt32 BI_StartSkill_06;
            public UInt32 BI_StartSkill_07;
            public UInt32 BI_StartSkill_08;
            public UInt32 BI_StartSkill_09;
            public UInt32 BI_StartSkill_10;
            public UInt32 BI_StartSkill_11;
            public UInt32 BI_StartSkill_12;
            public UInt32 BI_StartSkill_13;
            public UInt32 BI_StartSkill_14;
            public UInt32 BI_StartSkill_15;


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
