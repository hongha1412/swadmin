using System;

namespace SWAdmin.TableStruct
{
    public class TBDROPRATELEVELServer : BaseStruct
    {
        public DROPRATE_LEVELInfo[] lsData;
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

        public class DROPRATE_LEVELInfo : BaseStruct
        {
            public Byte DropRate_Party_LevelInterval;
            public float DropRate_LevelInterval_Value;


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
