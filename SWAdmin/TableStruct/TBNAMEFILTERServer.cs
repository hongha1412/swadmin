using System;

namespace SWAdmin.TableStruct
{
    public class TBNAMEFILTERServer : BaseStruct
    {
        public NAMEFILTERInfo[] lsData;
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

        public class NAMEFILTERInfo : BaseStruct
        {
            public UInt32 Filter_Index;
            public Byte Filter_Type;
            public String Filter_Word_String = "";


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
