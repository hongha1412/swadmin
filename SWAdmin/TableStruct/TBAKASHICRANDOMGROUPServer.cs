using System;

namespace SWAdmin.TableStruct
{
    public class TBAKASHICRANDOMGROUPServer : BaseStruct
    {
        public AKASHIC_RANDOM_GROUPInfo[] lsData;
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

        public class AKASHIC_RANDOM_GROUPInfo : BaseStruct
        {
            public UInt32 Akashic_Random_Group_ID;
            public UInt32 Akashic_Group_01;
            public UInt32 Akashic_Group_02;
            public UInt32 Akashic_Group_03;
            public UInt32 Akashic_Group_04;
            public UInt32 Akashic_Group_05;
            public UInt32 Akashic_Group_06;
            public UInt32 Akashic_Group_07;
            public UInt32 Akashic_Group_08;
            public UInt32 Akashic_Group_09;
            public UInt32 Akashic_Group_10;
            public UInt16 Chance_01;
            public UInt16 Chance_02;
            public UInt16 Chance_03;
            public UInt16 Chance_04;
            public UInt16 Chance_05;
            public UInt16 Chance_06;
            public UInt16 Chance_07;
            public UInt16 Chance_08;
            public UInt16 Chance_09;
            public UInt16 Chance_10;


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
