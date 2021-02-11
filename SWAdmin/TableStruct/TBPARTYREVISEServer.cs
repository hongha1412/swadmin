using System;

namespace SWAdmin.TableStruct
{
    public class TBPARTYREVISEServer : BaseStruct
    {
        public PARTYREVISEInfo[] lsData;
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

        public class PARTYREVISEInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 GroupID;
            public Byte Member_Count;
            public float Rev_HP_RAT;
            public float Rev_ATK_RAT;
            public float Rev_DEF_RAT;
            public float Rev_ASR_RAT;
            public float Rev_MSR_RAT;
            public float SuperArmor_Guage;
            public UInt32 SA_Regen_Time;
            public UInt32 SA_Recover_Time;


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
