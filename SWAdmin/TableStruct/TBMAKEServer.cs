using System;

namespace SWAdmin.TableStruct
{
    public class TBMAKEServer : BaseStruct
    {
        public MAKEInfo[] lsData;
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

        public class MAKEInfo : BaseStruct
        {
            public UInt32 Make_Index;
            public UInt32 Group_ID;
            public UInt16 Need_Fate;
            public UInt32 Need_Gold;
            public UInt16 M_priority;
            public Byte Limit_Type;
            public UInt16 Limit_Count;
            public Byte Limit_Reset_Time_PeriodType;
            public UInt32 MakeItem_ID_01;
            public UInt32 MakeItem_ID_02;
            public UInt32 MakeItem_ID_03;
            public UInt16 Rate_ID_01;
            public UInt16 Rate_ID_02;
            public UInt16 Rate_ID_03;
            public UInt32 Need_M_1;
            public UInt32 Need_M_2;
            public UInt32 Need_M_3;
            public UInt32 Need_M_4;
            public UInt16 M_Count_1;
            public UInt16 M_Count_2;
            public UInt16 M_Count_3;
            public UInt16 M_Count_4;


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
