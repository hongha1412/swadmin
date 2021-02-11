using System;

namespace SWAdmin.TableStruct
{
    public class TBFACTIONServer : BaseStruct
    {
        public FACTIONInfo[] lsData;
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

        public class FACTIONInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Local_Faction_Type;
            public Byte Enamy_Faction_Type;
            public Byte Faction_Type;


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
