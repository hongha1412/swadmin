using System;

namespace SWAdmin.TableStruct
{
    public class TBSOULGUAGEServer : BaseStruct
    {
        public SOUL_GUAGEInfo[] lsData;
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

        public class SOUL_GUAGEInfo : BaseStruct
        {
            public Byte SG_Index;
            public Byte SG_Regen_Type;
            public UInt32 Delay_Time;
            public Byte SG_Reset;
            public Byte Buff_Condition_Type;
            public UInt16 Buff_Condition;
            public UInt16 Get_Buff_ID;


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
