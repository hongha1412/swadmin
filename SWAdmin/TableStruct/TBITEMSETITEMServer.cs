using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMSETITEMServer : BaseStruct
    {
        public ITEM_SETITEMInfo[] lsData;
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

        public class ITEM_SETITEMInfo : BaseStruct
        {
            public UInt32 SetItem_ID;
            public UInt16 Set_Name_ID;
            public Byte Set_Count;
            public Byte Group_01;
            public Byte Group_02;
            public Byte Group_03;
            public Byte Group_04;
            public Byte Group_05;
            public Byte Set01_Class_1;
            public Byte Set02_Class_1;
            public Byte Set03_Class_1;
            public Byte Set04_Class_1;
            public Byte Set05_Class_1;
            public Byte Set01_Class_2;
            public Byte Set02_Class_2;
            public Byte Set03_Class_2;
            public Byte Set04_Class_2;
            public Byte Set05_Class_2;
            public UInt16 Set01_Type2;
            public UInt16 Set02_Type2;
            public UInt16 Set03_Type2;
            public UInt16 Set04_Type2;
            public UInt16 Set05_Type2;
            public Byte Set01_Class_3;
            public Byte Set02_Class_3;
            public Byte Set03_Class_3;
            public Byte Set04_Class_3;
            public Byte Set05_Class_3;
            public Byte Set01_Class_4;
            public Byte Set02_Class_4;
            public Byte Set03_Class_4;
            public Byte Set04_Class_4;
            public Byte Set05_Class_4;
            public UInt16 Set01_Type4;
            public UInt16 Set02_Type4;
            public UInt16 Set03_Type4;
            public UInt16 Set04_Type4;
            public UInt16 Set05_Type4;
            public float Set01_Value4;
            public float Set02_Value4;
            public float Set03_Value4;
            public float Set04_Value4;
            public float Set05_Value4;


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
