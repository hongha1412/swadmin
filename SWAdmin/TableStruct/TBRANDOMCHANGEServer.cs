using System;

namespace SWAdmin.TableStruct
{
    public class TBRANDOMCHANGEServer : BaseStruct
    {
        public RANDOM_CHANGEInfo[] lsData;
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

        public class RANDOM_CHANGEInfo : BaseStruct
        {
            public UInt32 Option_Change_ID;
            public Byte Max_Change_Cnt;
            public UInt32 Need_Item;
            public UInt16 Need_BP;
            public Byte Needitem_Cnt1;
            public Byte Needitem_Cnt2;
            public Byte Needitem_Cnt3;
            public Byte Needitem_Cnt4;
            public Byte Needitem_Cnt5;


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
