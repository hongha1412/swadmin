using System;

namespace SWAdmin.TableStruct
{
    public class TBCREATEOPTIONServer : BaseStruct
    {
        public CREATEOPTIONInfo[] lsData;
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

        public class CREATEOPTIONInfo : BaseStruct
        {
            public UInt16 EffectType_Index;
            public Byte Option_Class;
            public Byte Invoke_Area;
            public Byte Invoke_Target;
            public Byte Invoke_Condition;
            public Byte Situation_Check;
            public Int32 Aid_Value;
            public Byte Aid_Clm;
            public Byte Chance_Clm;
            public Byte Apply_Target;
            public Byte Refer_Status;
            public UInt32 StatusType;
            public Byte Value_Clm;
            public Int32 Value_Clmcrt;


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
