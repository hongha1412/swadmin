using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMCOUNTBOXServer : BaseStruct
    {
        public ITEM_COUNTBOXInfo[] lsData;
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

        public class ITEM_COUNTBOXInfo : BaseStruct
        {
            public UInt32 CountBox_ID;
            public Byte Usage_Cnt;
            public UInt16 Usage_Group_1_ID;
            public UInt16 Usage_Group_2_ID;
            public UInt16 Usage_Group_3_ID;
            public UInt16 Usage_Group_4_ID;
            public UInt16 Usage_Group_5_ID;
            public UInt16 Usage_Group_6_ID;
            public UInt16 Usage_Group_7_ID;
            public UInt16 Usage_Group_8_ID;
            public UInt16 Usage_Group_9_ID;
            public UInt16 Usage_Group_10_ID;
            public UInt16 Usage_Group_11_ID;
            public UInt16 Usage_Group_12_ID;
            public UInt16 Usage_Group_13_ID;
            public UInt16 Usage_Group_14_ID;
            public UInt16 Usage_Group_15_ID;
            public UInt16 Usage_Group_16_ID;
            public UInt16 Usage_Group_17_ID;
            public UInt16 Usage_Group_18_ID;
            public UInt16 Usage_Group_19_ID;
            public UInt16 Usage_Group_20_ID;
            public UInt16 Usage_Group_21_ID;
            public UInt16 Usage_Group_22_ID;
            public UInt16 Usage_Group_23_ID;
            public UInt16 Usage_Group_24_ID;
            public UInt16 Usage_Group_25_ID;
            public UInt16 Usage_Group_26_ID;
            public UInt16 Usage_Group_27_ID;
            public UInt16 Usage_Group_28_ID;
            public UInt16 Usage_Group_29_ID;
            public UInt16 Usage_Group_30_ID;


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
