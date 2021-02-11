using System;

namespace SWAdmin.TableStruct
{
    public class TBBANKSLOTEXTENDServer : BaseStruct
    {
        public BANK_SLOT_EXTENDInfo[] lsData;
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

        public class BANK_SLOT_EXTENDInfo : BaseStruct
        {
            public Byte Extend_Index;
            public Byte Extend_Step;
            public Byte Bank_Lv_1;
            public Byte Extend_Need_1;
            public UInt32 Extend_Value_1;
            public Byte Add_Slot_1;
            public UInt16 Accrue_Slot_1;
            public Byte Bank_Lv_2;
            public Byte Extend_Need_2;
            public UInt32 Extend_Value_2;
            public Byte Add_Slot_2;
            public UInt16 Accrue_Slot_2;


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
