using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMCOUNTBOXGROUPServer : BaseStruct
    {
        public ITEM_COUNTBOX_GROUPInfo[] lsData;
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

        public class ITEM_COUNTBOX_GROUPInfo : BaseStruct
        {
            public UInt32 Count_Group_ID;
            public UInt32 Item_1;
            public UInt32 Item_2;
            public UInt32 Item_3;
            public UInt32 Item_4;
            public UInt32 Item_5;
            public UInt32 Item_6;
            public UInt32 Item_7;
            public UInt32 Item_8;
            public UInt32 Item_9;
            public UInt32 Item_10;
            public UInt32 Item_11;
            public UInt32 Item_12;
            public UInt32 Item_13;
            public UInt32 Item_14;
            public UInt32 Item_15;
            public Byte Item_Cnt_1;
            public Byte Item_Cnt_2;
            public Byte Item_Cnt_3;
            public Byte Item_Cnt_4;
            public Byte Item_Cnt_5;
            public Byte Item_Cnt_6;
            public Byte Item_Cnt_7;
            public Byte Item_Cnt_8;
            public Byte Item_Cnt_9;
            public Byte Item_Cnt_10;
            public Byte Item_Cnt_11;
            public Byte Item_Cnt_12;
            public Byte Item_Cnt_13;
            public Byte Item_Cnt_14;
            public Byte Item_Cnt_15;


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
