using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMSIMILARGROUPServer : BaseStruct
    {
        public ITEM_SIMILARGROUPInfo[] lsData;
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

        public class ITEM_SIMILARGROUPInfo : BaseStruct
        {
            public UInt32 Group_Index;
            public UInt32 Similar_Item_01;
            public UInt32 Similar_Item_02;
            public UInt32 Similar_Item_03;
            public UInt32 Similar_Item_04;
            public UInt32 Similar_Item_05;


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
