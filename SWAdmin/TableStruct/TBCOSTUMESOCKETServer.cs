using System;

namespace SWAdmin.TableStruct
{
    public class TBCOSTUMESOCKETServer : BaseStruct
    {
        public COSTUME_SOCKETInfo[] lsData;
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

        public class COSTUME_SOCKETInfo : BaseStruct
        {
            public UInt32 Socket_ID;
            public Byte Socket_Piece_EA;
            public UInt32 Add_Item;
            public UInt16 Add_Count;
            public Byte Fix_Socket1;
            public Byte Fix_Socket2;
            public Byte Fix_Socket3;
            public Byte Fix_Socket4;
            public Byte Fix_Socket5;
            public Byte Extend_Socket1;
            public Byte Extend_Socket2;
            public Byte Extend_Socket3;
            public Byte Extend_Socket4;
            public Byte Extend_Socket5;


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
