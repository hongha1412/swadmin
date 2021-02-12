using System;

namespace SWAdmin.TableStruct
{
    public class TBOPTIONSTRINGServer : BaseStruct
    {
        public OPTION_STRINGInfo[] lsData;
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

        public class OPTION_STRINGInfo : BaseStruct
        {
            public UInt16 Option_Name_ID;
            public Byte EffectType;
            public UInt16 Effect_Num;
            public String UI_String_String = "";
            public Byte Output_Type;


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
