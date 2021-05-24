using System;

namespace SWAdmin.TableStruct
{
    public class TBDYEINFOServer : BaseStruct
    {
        public DYE_INFOInfo[] lsData;
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

        public class DYE_INFOInfo : BaseStruct
        {
            public UInt16 Dye_Info_ID;
            public UInt32 S_Dye_Need_Item_ID;
            public UInt32 S_Dye_Need_Item_CNT;
            public UInt16 S_Dye_1;
            public UInt16 S_Dye_2;
            public UInt16 S_Dye_3;
            public UInt16 S_Dye_4;
            public UInt16 S_Dye_5;
            public UInt16 S_Dye_6;
            public UInt16 S_Dye_7;
            public UInt16 S_Dye_8;
            public UInt16 S_Dye_9;
            public UInt16 S_Dye_10;
            public UInt32 R_Dye_Need_Item_ID;
            public Byte R_Dye_Need_Item_CNT;
            public UInt16 Dye_Rate_ID_1;
            public UInt16 Dye_Rate_ID_2;
            public UInt16 Dye_Rate_ID_3;
            public UInt16 Dye_Rate_ID_4;
            public UInt16 Dye_Rate_ID_5;
            public UInt16 Dye_Rate_ID_6;
            public UInt16 Dye_Rate_ID_7;
            public UInt16 Dye_Rate_ID_8;
            public UInt16 Dye_Rate_ID_9;
            public UInt16 Dye_Rate_ID_10;
            public UInt16 Dye_Rate_1;
            public UInt16 Dye_Rate_2;
            public UInt16 Dye_Rate_3;
            public UInt16 Dye_Rate_4;
            public UInt16 Dye_Rate_5;
            public UInt16 Dye_Rate_6;
            public UInt16 Dye_Rate_7;
            public UInt16 Dye_Rate_8;
            public UInt16 Dye_Rate_9;
            public UInt16 Dye_Rate_10;


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
