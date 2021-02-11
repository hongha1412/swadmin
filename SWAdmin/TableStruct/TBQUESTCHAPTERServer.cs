using System;

namespace SWAdmin.TableStruct
{
    public class TBQUESTCHAPTERServer : BaseStruct
    {
        public QUEST_CHAPTERInfo[] lsData;
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

        public class QUEST_CHAPTERInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Season_ID;
            public UInt32 Episode_ID_01;
            public UInt32 Episode_ID_02;
            public UInt32 Episode_ID_03;
            public UInt32 Episode_ID_04;
            public UInt32 Episode_ID_05;
            public UInt32 Episode_ID_06;
            public UInt32 Episode_ID_07;
            public UInt32 Episode_ID_08;
            public UInt32 Episode_ID_09;
            public UInt32 Episode_ID_10;
            public UInt32 Episode_ID_11;
            public UInt32 Episode_ID_12;
            public UInt32 Episode_ID_13;
            public UInt32 Episode_ID_14;
            public UInt32 Episode_ID_15;


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
