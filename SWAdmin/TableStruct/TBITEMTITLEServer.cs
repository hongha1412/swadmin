using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMTITLEServer : BaseStruct
    {
        public ITEM_TITLEInfo[] lsData;
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

        public class ITEM_TITLEInfo : BaseStruct
        {
            public UInt32 Title_Group_ID;
            public UInt32 Group_ID01;
            public UInt32 Group_ID02;
            public UInt32 Group_ID03;
            public UInt32 Group_ID04;
            public UInt32 Group_ID05;
            public UInt32 Group_ID06;
            public UInt32 Group_ID07;
            public UInt32 Group_ID08;
            public UInt32 Group_ID09;
            public UInt32 Group_ID10;
            public Int16 Group_rate01;
            public Int16 Group_rate02;
            public Int16 Group_rate03;
            public Int16 Group_rate04;
            public Int16 Group_rate05;
            public Int16 Group_rate06;
            public Int16 Group_rate07;
            public Int16 Group_rate08;
            public Int16 Group_rate09;
            public Int16 Group_rate10;


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
