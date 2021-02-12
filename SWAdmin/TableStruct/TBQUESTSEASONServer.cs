using System;

namespace SWAdmin.TableStruct
{
    public class TBQUESTSEASONServer : BaseStruct
    {
        public QUEST_SEASONInfo[] lsData;
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

        public class QUEST_SEASONInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Chapter_ID_01;
            public UInt32 Chapter_ID_02;
            public UInt32 Chapter_ID_03;
            public UInt32 Chapter_ID_04;
            public UInt32 Chapter_ID_05;
            public UInt32 Chapter_ID_06;
            public UInt32 Chapter_ID_07;
            public UInt32 Chapter_ID_08;
            public UInt32 Chapter_ID_09;


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
