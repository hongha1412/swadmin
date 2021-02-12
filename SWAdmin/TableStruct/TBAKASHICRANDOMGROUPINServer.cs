using System;

namespace SWAdmin.TableStruct
{
    public class TBAKASHICRANDOMGROUPINServer : BaseStruct
    {
        public AKASHIC_RANDOM_GROUP_INInfo[] lsData;
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

        public class AKASHIC_RANDOM_GROUP_INInfo : BaseStruct
        {
            public UInt32 Akashic_Group_ID;
            public UInt32 Akashic_Record_ID_01;
            public UInt32 Akashic_Record_ID_02;
            public UInt32 Akashic_Record_ID_03;
            public UInt32 Akashic_Record_ID_04;
            public UInt32 Akashic_Record_ID_05;
            public UInt32 Akashic_Record_ID_06;
            public UInt32 Akashic_Record_ID_07;
            public UInt32 Akashic_Record_ID_08;
            public UInt32 Akashic_Record_ID_09;
            public UInt32 Akashic_Record_ID_10;
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
