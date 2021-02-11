using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMSCRIPTServer : BaseStruct
    {
        public ITEM_SCRIPTInfo[] lsData;
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

        public class ITEM_SCRIPTInfo : BaseStruct
        {
            public UInt32 Item_Script_ID;
            public String Item_NameS_String = "";


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
