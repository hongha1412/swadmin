using System;

namespace SWAdmin.TableStruct
{
    public class TBRANDOMGETGROUPServer : BaseStruct
    {
        public RANDOM_GET_GROUPInfo[] lsData;
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

        public class RANDOM_GET_GROUPInfo : BaseStruct
        {
            public UInt16 Random_Get_ID;
            public UInt32 Group_Des;
            public Byte UI_Effect_Type;
            public Byte Period_Use;
            public UInt16 Start_Year;
            public Byte Start_Month;
            public Byte Start_Day;
            public UInt16 End_Year;
            public Byte End_Month;
            public Byte End_Day;
            public UInt16 Gacha_Group_ID;
            public UInt16 Group_ID_01;
            public UInt16 Group_ID_02;
            public UInt16 Group_ID_03;
            public UInt16 Group_ID_04;
            public UInt16 Group_ID_05;
            public UInt16 Group_ID_06;
            public UInt16 Group_ID_07;
            public UInt16 Group_ID_08;
            public UInt16 Group_ID_09;
            public UInt16 Group_ID_10;
            public UInt16 Group_ID_11;
            public UInt16 Group_ID_12;
            public UInt16 Group_ID_13;
            public UInt16 Group_ID_14;
            public UInt16 Group_ID_15;
            public UInt16 Group_ID_16;
            public UInt16 Group_ID_17;
            public UInt16 Group_ID_18;
            public UInt16 Group_ID_19;
            public UInt16 Group_ID_20;


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
