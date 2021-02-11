using System;

namespace SWAdmin.TableStruct
{
    public class TBSLOTEXTENDServer : BaseStruct
    {
        public SLOT_EXTENDInfo[] lsData;
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

        public class SLOT_EXTENDInfo : BaseStruct
        {
            public Int32 nAbilityPrice;
            public Byte byAbilitySlot;
            public Int32 nShapePrice;
            public Byte byShapeSlot;
            public Int32 nBankPrice;
            public Byte byBankSlot;


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
