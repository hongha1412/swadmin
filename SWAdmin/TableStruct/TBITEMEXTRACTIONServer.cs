using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMEXTRACTIONServer : BaseStruct
    {
        public ITEM_EXTRACTIONInfo[] lsData;
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

        public class ITEM_EXTRACTIONInfo : BaseStruct
        {
            public UInt32 Item_ID;
            public UInt32 Extraction_gold;


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
