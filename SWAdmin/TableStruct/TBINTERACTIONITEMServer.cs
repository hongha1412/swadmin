using System;

namespace SWAdmin.TableStruct
{
    public class TBINTERACTIONITEMServer : BaseStruct
    {
        public INTERACTION_ITEMInfo[] lsData;
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

        public class INTERACTION_ITEMInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt16 Item_Rate_01;
            public UInt16 Item_Rate_02;
            public UInt16 Item_Rate_03;
            public UInt16 Item_Rate_04;
            public UInt16 Item_Rate_05;
            public UInt16 Item_Rate_06;
            public UInt16 Item_Rate_07;
            public UInt16 Item_Rate_08;
            public UInt16 Item_Rate_09;
            public UInt16 Item_Rate_10;
            public UInt32 Item_ID_01;
            public UInt32 Item_ID_02;
            public UInt32 Item_ID_03;
            public UInt32 Item_ID_04;
            public UInt32 Item_ID_05;
            public UInt32 Item_ID_06;
            public UInt32 Item_ID_07;
            public UInt32 Item_ID_08;
            public UInt32 Item_ID_09;
            public UInt32 Item_ID_10;
            public UInt16 Item_Value_Min_01;
            public UInt16 Item_Value_Min_02;
            public UInt16 Item_Value_Min_03;
            public UInt16 Item_Value_Min_04;
            public UInt16 Item_Value_Min_05;
            public UInt16 Item_Value_Min_06;
            public UInt16 Item_Value_Min_07;
            public UInt16 Item_Value_Min_08;
            public UInt16 Item_Value_Min_09;
            public UInt16 Item_Value_Min_10;
            public UInt16 Item_Value_Max_01;
            public UInt16 Item_Value_Max_02;
            public UInt16 Item_Value_Max_03;
            public UInt16 Item_Value_Max_04;
            public UInt16 Item_Value_Max_05;
            public UInt16 Item_Value_Max_06;
            public UInt16 Item_Value_Max_07;
            public UInt16 Item_Value_Max_08;
            public UInt16 Item_Value_Max_09;
            public UInt16 Item_Value_Max_10;


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
