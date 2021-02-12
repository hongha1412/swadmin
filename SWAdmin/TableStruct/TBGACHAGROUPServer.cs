using System;

namespace SWAdmin.TableStruct
{
    public class TBGACHAGROUPServer : BaseStruct
    {
        public GACHA_GROUPInfo[] lsData;
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

        public class GACHA_GROUPInfo : BaseStruct
        {
            public UInt16 Gacha_Chance_ID;
            public String Des_String = "";
            public UInt16 Gacha_Group_ID;
            public Byte Gacha_Chance_On_Off;
            public UInt16 G_Chance_01;
            public UInt16 G_Chance_02;
            public UInt16 G_Chance_03;
            public UInt16 G_Chance_04;
            public UInt16 G_Chance_05;
            public UInt16 G_Chance_06;
            public UInt16 G_Chance_07;
            public UInt16 G_Chance_08;
            public UInt16 G_Chance_09;
            public UInt16 G_Chance_10;
            public UInt16 G_Chance_11;
            public UInt16 G_Chance_12;
            public UInt16 G_Chance_13;
            public UInt16 G_Chance_14;
            public UInt16 G_Chance_15;
            public UInt16 G_Chance_16;
            public UInt16 G_Chance_17;
            public UInt16 G_Chance_18;
            public UInt16 G_Chance_19;
            public UInt16 G_Chance_20;


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
