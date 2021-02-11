using System;

namespace SWAdmin.TableStruct
{
    public class TBCHANGEMOBIDServer : BaseStruct
    {
        public CHANGE_MOB_IDInfo[] lsData;
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

        public class CHANGE_MOB_IDInfo : BaseStruct
        {
            public UInt32 MOB_ID_Difficulty01;
            public UInt32 MOB_ID_Difficulty02;
            public UInt32 MOB_ID_Difficulty03;


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
