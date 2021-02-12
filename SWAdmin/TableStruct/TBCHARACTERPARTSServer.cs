using System;

namespace SWAdmin.TableStruct
{
    public class TBCHARACTERPARTSServer : BaseStruct
    {
        public CHARACTER_PARTSInfo[] lsData;
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

        public class CHARACTER_PARTSInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Parts_Position;


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
