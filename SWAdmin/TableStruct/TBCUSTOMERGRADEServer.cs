using System;

namespace SWAdmin.TableStruct
{
    public class TBCUSTOMERGRADEServer : BaseStruct
    {
        public CUSTOMER_GRADEInfo[] lsData;
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

        public class CUSTOMER_GRADEInfo : BaseStruct
        {
            public UInt16 Index;
            public UInt16 Npc_Group_ID;
            public Byte Customer_Grade;
            public UInt16 Need_Credit;
            public UInt16 Credit_Accrue;
            public Byte Day_Credit_Limit;
            public UInt32 Reward_Item;
            public Byte Reward_Item_Count;
            public UInt32 Benefit_ID_01;
            public UInt32 Benefit_ID_02;
            public UInt32 Benefit_ID_03;
            public UInt32 Benefit_ID_04;
            public UInt32 Benefit_ID_05;
            public UInt32 Benefit_ID_06;


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
