using System;

namespace SWAdmin.TableStruct
{
    public class TBCREDITRAISEServer : BaseStruct
    {
        public CREDIT_RAISEInfo[] lsData;
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

        public class CREDIT_RAISEInfo : BaseStruct
        {
            public UInt16 Index;
            public UInt16 Npc_Group_ID;
            public Byte Credit_Raise_Type;
            public Byte Raise_Count_Min;
            public Byte Raise_Count_Max;


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
