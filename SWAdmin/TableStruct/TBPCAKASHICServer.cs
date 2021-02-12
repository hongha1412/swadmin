using System;

namespace SWAdmin.TableStruct
{
    public class TBPCAKASHICServer : BaseStruct
    {
        public PC_AKASHICInfo[] lsData;
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

        public class PC_AKASHICInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Akashic_ID;


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
