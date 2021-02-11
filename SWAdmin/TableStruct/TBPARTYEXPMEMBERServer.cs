using System;

namespace SWAdmin.TableStruct
{
    public class TBPARTYEXPMEMBERServer : BaseStruct
    {
        public PARTYEXP_MEMBERInfo[] lsData;
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

        public class PARTYEXP_MEMBERInfo : BaseStruct
        {
            public Byte Party_Member_ID;
            public Byte Party_Member;
            public Byte Friend_Value;
            public UInt16 Booster_ID;


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
