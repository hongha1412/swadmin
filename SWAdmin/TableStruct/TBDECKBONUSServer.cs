using System;

namespace SWAdmin.TableStruct
{
    public class TBDECKBONUSServer : BaseStruct
    {
        public DECK_BONUSInfo[] lsData;
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

        public class DECK_BONUSInfo : BaseStruct
        {
            public UInt16 Bonus_Index;
            public Byte Use_DeckPhase;
            public Byte Bonus_Type;
            public Byte Bonus_Need_Lv;
            public float Bonus_Value;


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
