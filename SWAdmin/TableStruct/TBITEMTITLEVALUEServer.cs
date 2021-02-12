using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMTITLEVALUEServer : BaseStruct
    {
        public ITEM_TITLE_VALUEInfo[] lsData;
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

        public class ITEM_TITLE_VALUEInfo : BaseStruct
        {
            public UInt32 Item_Title_ID;
            public String UI_String_String = "";
            public Byte Additional_Option0_Type;
            public Byte Additional_Option1_Type;
            public Byte Additional_Option2_Type;
            public Int16 Increase_Default_Value0;
            public Int16 Additional_Option_Value1;
            public Int16 Additional_Option_Value2;


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
