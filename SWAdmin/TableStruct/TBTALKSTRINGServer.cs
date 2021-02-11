using System;

namespace SWAdmin.TableStruct
{
    public class TBTALKSTRINGServer : BaseStruct
    {
        public TALK_STRINGInfo[] lsData;
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

        public class TALK_STRINGInfo : BaseStruct
        {
            public UInt16 Talk_Str_ID;
            public String Talk_Str_String = "";


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
