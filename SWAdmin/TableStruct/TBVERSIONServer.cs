using System;

namespace SWAdmin.TableStruct
{
    public class TBVERSIONServer : BaseStruct
    {
        public VERSIONInfo[] lsData;
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

        public class VERSIONInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 MainVer;
            public UInt32 SubVer;
            public UInt32 DataVer;


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
