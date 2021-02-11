using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMTITLECHANGEServer : BaseStruct
    {
        public ITEM_TITLE_CHANGEInfo[] lsData;
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

        public class ITEM_TITLE_CHANGEInfo : BaseStruct
        {
            public UInt16 Tag_Change_ID;
            public UInt16 Basic_Success_Rate;
            public UInt16 Need_Point;
            public UInt32 Need_Zeny;
            public UInt32 Need_Ether;


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
