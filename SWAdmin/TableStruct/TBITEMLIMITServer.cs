using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMLIMITServer : BaseStruct
    {
        public ITEM_LIMITInfo[] lsData;
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

        public class ITEM_LIMITInfo : BaseStruct
        {
            public UInt32 Limit_Item_ID;
            public UInt16 Limit_Cnt;


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
