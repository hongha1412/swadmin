using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMTITLEGROUPServer : BaseStruct
    {
        public ITEM_TITLE_GROUPInfo[] lsData;
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

        public class ITEM_TITLE_GROUPInfo : BaseStruct
        {
            public UInt32 T_Item_Title_G_ID;
            public UInt32 T_Group01_ID_1;
            public UInt32 T_Group01_ID_2;
            public UInt32 T_Group01_ID_3;
            public UInt32 T_Group01_ID_4;
            public UInt32 T_Group01_ID_5;
            public UInt32 T_Group01_ID_6;
            public UInt32 T_Group01_ID_7;
            public UInt32 T_Group01_ID_8;
            public UInt32 T_Group01_ID_9;
            public UInt32 T_Group01_ID_10;
            public Int16 T_Group01_Rate_1;
            public Int16 T_Group01_Rate_2;
            public Int16 T_Group01_Rate_3;
            public Int16 T_Group01_Rate_4;
            public Int16 T_Group01_Rate_5;
            public Int16 T_Group01_Rate_6;
            public Int16 T_Group01_Rate_7;
            public Int16 T_Group01_Rate_8;
            public Int16 T_Group01_Rate_9;
            public Int16 T_Group01_Rate_10;


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
