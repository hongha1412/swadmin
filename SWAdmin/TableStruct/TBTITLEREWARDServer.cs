using System;

namespace SWAdmin.TableStruct
{
    public class TBTITLEREWARDServer : BaseStruct
    {
        public TITLE_REWARDInfo[] lsData;
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

        public class TITLE_REWARDInfo : BaseStruct
        {
            public UInt32 Title_Reward_ID;
            public UInt32 Title_ID_01;
            public UInt32 Title_ID_02;
            public UInt32 Title_ID_03;
            public UInt32 Title_ID_04;
            public UInt32 Title_ID_05;
            public UInt32 Title_ID_06;
            public UInt32 Title_ID_07;
            public UInt32 Title_ID_08;


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
