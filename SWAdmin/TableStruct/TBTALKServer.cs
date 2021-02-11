using System;

namespace SWAdmin.TableStruct
{
    public class TBTALKServer : BaseStruct
    {
        public TALKInfo[] lsData;
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

        public class TALKInfo : BaseStruct
        {
            public UInt32 Talk_Index;
            public Byte Talk_Type;
            public UInt16 Talk_Title_ID;
            public UInt32 Linked_Order_ID;
            public Byte Linked_Order_Type;
            public UInt32 Linked_Episode_ID;
            public Byte Linked_Episode_Type;
            public UInt32 Playing_Order_ID;
            public UInt32 Complete_Episode_ID;
            public UInt32 Speech_ID_01;
            public UInt32 Speech_ID_02;
            public UInt32 Speech_ID_03;
            public UInt32 Speech_ID_04;
            public UInt32 Speech_ID_05;
            public UInt32 Speech_ID_06;
            public UInt32 Speech_ID_07;
            public UInt32 Speech_ID_08;
            public UInt32 Speech_ID_09;
            public UInt32 Speech_ID_10;
            public UInt32 Speech_ID_11;
            public UInt32 Speech_ID_12;
            public UInt32 Speech_ID_13;
            public UInt32 Speech_ID_14;
            public UInt32 Speech_ID_15;
            public UInt32 Speech_ID_16;
            public UInt32 Speech_ID_17;
            public UInt32 Speech_ID_18;
            public UInt32 Speech_ID_19;
            public UInt32 Speech_ID_20;
            public UInt32 Speech_ID_21;
            public UInt32 Speech_ID_22;
            public UInt32 Speech_ID_23;
            public UInt32 Speech_ID_24;
            public UInt32 Speech_ID_25;
            public UInt32 Speech_ID_26;
            public UInt32 Speech_ID_27;
            public UInt32 Speech_ID_28;
            public UInt32 Speech_ID_29;
            public UInt32 Speech_ID_30;


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
