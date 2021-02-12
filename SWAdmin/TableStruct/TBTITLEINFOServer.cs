using System;

namespace SWAdmin.TableStruct
{
    public class TBTITLEINFOServer : BaseStruct
    {
        public TITLE_INFOInfo[] lsData;
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

        public class TITLE_INFOInfo : BaseStruct
        {
            public UInt32 ID;
            public String Title_Name_String = "";
            public Byte Title_Type;
            public Byte Use_Class;
            public UInt16 Title_Array_Num;
            public Byte Open_Condition;
            public UInt32 Open_Condition_Value;
            public Byte Info_Type;
            public Byte Effect_Class_01;
            public Byte Effect_Class_02;
            public Byte Effect_Class_03;
            public Byte Effect_Class_04;
            public Byte Effect_Class_05;
            public UInt16 Effect_Type_01;
            public UInt16 Effect_Type_02;
            public UInt16 Effect_Type_03;
            public UInt16 Effect_Type_04;
            public UInt16 Effect_Type_05;
            public float Effect_value_01;
            public float Effect_value_02;
            public float Effect_value_03;
            public float Effect_value_04;
            public float Effect_value_05;


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
