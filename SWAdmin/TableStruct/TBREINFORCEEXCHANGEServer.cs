using System;

namespace SWAdmin.TableStruct
{
    public class TBREINFORCEEXCHANGEServer : BaseStruct
    {
        public REINFORCE_EXCHANGEInfo[] lsData;
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

        public class REINFORCE_EXCHANGEInfo : BaseStruct
        {
            public UInt32 R_Exchange_ID;
            public Byte NPC_Type;
            public UInt32 M_Item;
            public Byte M_Count;
            public UInt32 Ex_Item;
            public Byte Ex_Count;


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
