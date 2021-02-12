using System;

namespace SWAdmin.TableStruct
{
    public class TBPCCOSTUMEServer : BaseStruct
    {
        public PC_COSTUMEInfo[] lsData;
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

        public class PC_COSTUMEInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Item_ID;


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
