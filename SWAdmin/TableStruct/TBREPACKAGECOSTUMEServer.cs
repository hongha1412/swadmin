using System;

namespace SWAdmin.TableStruct
{
    public class TBREPACKAGECOSTUMEServer : BaseStruct
    {
        public REPACKAGECOSTUMEInfo[] lsData;
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

        public class REPACKAGECOSTUMEInfo : BaseStruct
        {
            public UInt32 RePackageItem_ID;
            public UInt32 Item_01;
            public UInt32 Item_02;
            public UInt32 Item_03;
            public UInt32 Item_04;
            public UInt32 Item_05;
            public UInt32 Item_06;
            public UInt32 Item_07;
            public UInt32 Item_08;
            public UInt32 Item_09;
            public UInt32 Item_10;
            public UInt32 Item_11;
            public UInt32 Item_12;
            public UInt32 Item_13;


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
