using System;

namespace SWAdmin.TableStruct
{
    public class TBCUSTOMERBENEFITServer : BaseStruct
    {
        public CUSTOMER_BENEFITInfo[] lsData;
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

        public class CUSTOMER_BENEFITInfo : BaseStruct
        {
            public UInt32 Benefit_ID;
            public Byte Benefit_Type;
            public UInt16 Benefit_Value_Rate;
            public UInt16 Benefit_Value_Int;
            public UInt32 Helper_Quest_ID;
            public UInt32 Benefit_Item_ID_01;
            public UInt32 Benefit_Item_ID_02;
            public UInt32 Benefit_Item_ID_03;


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
