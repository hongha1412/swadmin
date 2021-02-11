using System;

namespace SWAdmin.TableStruct
{
    public class TBPARTYEXPMOBServer : BaseStruct
    {
        public PARTYEXP_MOBInfo[] lsData;
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

        public class PARTYEXP_MOBInfo : BaseStruct
        {
            public String Mob_LevelInterval_String = "";
            public float Mob_IntervalValue;


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
