using System;

namespace SWAdmin.TableStruct
{
    public class TBHELPERServer : BaseStruct
    {
        public HELPERInfo[] lsData;
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

        public class HELPERInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Helper_Number;


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
