using System;

namespace SWAdmin.TableStruct
{
    public class TBTITLESTRINGServer : BaseStruct
    {
        public TITLE_STRINGInfo[] lsData;
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

        public class TITLE_STRINGInfo : BaseStruct
        {
            public UInt32 Title_ID;
            public String Title_Name_String = "";


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
