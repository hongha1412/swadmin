using System;

namespace SWAdmin.TableStruct
{
    public class TBPARTYEXPLEVELServer : BaseStruct
    {
        public PARTYEXP_LEVELInfo[] lsData;
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

        public class PARTYEXP_LEVELInfo : BaseStruct
        {
            public Byte Party_LevelInterval;
            public float LevelInterval_Value;


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
