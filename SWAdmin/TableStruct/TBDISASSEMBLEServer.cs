using System;

namespace SWAdmin.TableStruct
{
    public class TBDISASSEMBLEServer : BaseStruct
    {
        public DISASSEMBLEInfo[] lsData;
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

        public class DISASSEMBLEInfo : BaseStruct
        {
            public UInt32 DA_ID;
            public UInt32 MIN_Ethel;
            public UInt32 MAX_Ethel;
            public UInt32 DA_Item_01;
            public UInt32 DA_Item_02;
            public UInt32 DA_Item_03;
            public UInt32 DA_Item_04;
            public UInt32 DA_Item_05;
            public UInt32 DA_Item_06;
            public UInt32 DA_Item_07;
            public UInt16 DA_Rate_01;
            public UInt16 DA_Rate_02;
            public UInt16 DA_Rate_03;
            public UInt16 DA_Rate_04;
            public UInt16 DA_Rate_05;
            public UInt16 DA_Rate_06;
            public UInt16 DA_Rate_07;
            public Byte Min_Value_01;
            public Byte Min_Value_02;
            public Byte Min_Value_03;
            public Byte Min_Value_04;
            public Byte Min_Value_05;
            public Byte Min_Value_06;
            public Byte Min_Value_07;
            public Byte Max_Value_01;
            public Byte Max_Value_02;
            public Byte Max_Value_03;
            public Byte Max_Value_04;
            public Byte Max_Value_05;
            public Byte Max_Value_06;
            public Byte Max_Value_07;


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
