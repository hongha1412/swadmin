using System;

namespace SWAdmin.TableStruct
{
    public class TBSOCKETServer : BaseStruct
    {
        public SOCKETInfo[] lsData;
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

        public class SOCKETInfo : BaseStruct
        {
            public UInt32 Socket_ID;
            public Byte Socket_Type;
            public Byte Max_Socket;
            public Byte Fix_Socket;
            public Byte Random_Socket;
            public UInt32 Euqip_Cost;
            public UInt32 Euqip_Item;
            public UInt16 Euqip_Count;
            public UInt32 Remove_Cost;
            public UInt32 Remove_Item;
            public UInt16 Remove_Count;
            public UInt32 Add_Cost;
            public UInt32 Add_Item;
            public UInt16 Add_Count;
            public UInt32 Extraction_Item;
            public UInt16 Extraction_Item_Count;
            public UInt16 R1_Chance;
            public UInt16 R2_Chance;
            public UInt16 R3_Chance;


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
