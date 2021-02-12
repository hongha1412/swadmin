using System;

namespace SWAdmin.TableStruct
{
    public class TBCREATECLOTHServer : BaseStruct
    {
        public CREATE_CLOTHInfo[] lsData;
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

        public class CREATE_CLOTHInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt32 Item_ID_Head;
            public UInt32 Item_ID_Body;
            public UInt32 Item_ID_Hands;
            public UInt32 Item_ID_Stocking;
            public UInt32 Item_ID_Foot;
            public UInt32 Item_ID_Pants;
            public String Icon_FileName_String = "";


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
