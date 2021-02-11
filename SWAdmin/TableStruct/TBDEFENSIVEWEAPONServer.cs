using System;

namespace SWAdmin.TableStruct
{
    public class TBDEFENSIVEWEAPONServer : BaseStruct
    {
        public DEFENSIVE_WEAPONInfo[] lsData;
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

        public class DEFENSIVE_WEAPONInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Monster_ID;


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
