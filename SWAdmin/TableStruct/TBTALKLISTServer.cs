using System;

namespace SWAdmin.TableStruct
{
    public class TBTALKLISTServer : BaseStruct
    {
        public TALK_LISTInfo[] lsData;
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

        public class TALK_LISTInfo : BaseStruct
        {
            public UInt16 Talk_List_ID;
            public UInt16 Talk_ID_01;
            public UInt16 Talk_ID_02;
            public UInt16 Talk_ID_03;
            public UInt16 Talk_ID_04;
            public UInt16 Talk_ID_05;
            public UInt16 Talk_ID_06;
            public UInt16 Talk_ID_07;
            public UInt16 Talk_ID_08;
            public UInt16 Talk_ID_09;
            public UInt16 Talk_ID_10;
            public UInt16 Talk_ID_11;
            public UInt16 Talk_ID_12;
            public UInt16 Talk_ID_13;
            public UInt16 Talk_ID_14;
            public UInt16 Talk_ID_15;
            public UInt16 Talk_ID_16;
            public UInt16 Talk_ID_17;
            public UInt16 Talk_ID_18;
            public UInt16 Talk_ID_19;
            public UInt16 Talk_ID_20;
            public UInt16 Talk_ID_21;
            public UInt16 Talk_ID_22;
            public UInt16 Talk_ID_23;
            public UInt16 Talk_ID_24;
            public UInt16 Talk_ID_25;


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
