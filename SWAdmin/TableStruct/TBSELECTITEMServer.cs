using System;

namespace SWAdmin.TableStruct
{
    public class TBSELECTITEMServer : BaseStruct
    {
        public SELECT_ITEMInfo[] lsData;
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

        public class SELECT_ITEMInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Selcect_CNT;
            public UInt32 Item_ID_1;
            public UInt32 Item_ID_2;
            public UInt32 Item_ID_3;
            public UInt32 Item_ID_4;
            public UInt32 Item_ID_5;
            public UInt32 Item_ID_6;
            public UInt32 Item_ID_7;
            public UInt32 Item_ID_8;
            public UInt32 Item_ID_9;
            public UInt32 Item_ID_10;
            public UInt32 Item_ID_11;
            public UInt32 Item_ID_12;
            public UInt32 Item_ID_13;
            public UInt32 Item_ID_14;
            public UInt32 Item_ID_15;
            public UInt16 Item_ID_Cnt_1;
            public UInt16 Item_ID_Cnt_2;
            public UInt16 Item_ID_Cnt_3;
            public UInt16 Item_ID_Cnt_4;
            public UInt16 Item_ID_Cnt_5;
            public UInt16 Item_ID_Cnt_6;
            public UInt16 Item_ID_Cnt_7;
            public UInt16 Item_ID_Cnt_8;
            public UInt16 Item_ID_Cnt_9;
            public UInt16 Item_ID_Cnt_10;
            public UInt16 Item_ID_Cnt_11;
            public UInt16 Item_ID_Cnt_12;
            public UInt16 Item_ID_Cnt_13;
            public UInt16 Item_ID_Cnt_14;
            public UInt16 Item_ID_Cnt_15;


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
