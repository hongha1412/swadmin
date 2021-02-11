using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDLEVELServer : BaseStruct
    {
        public MAZEREWARD_LEVELInfo[] lsData;
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

        public class MAZEREWARD_LEVELInfo : BaseStruct
        {
            public Byte ID;
            public Byte Level;
            public float Level_Value;


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
