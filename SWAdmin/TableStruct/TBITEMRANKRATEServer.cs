using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMRANKRATEServer : BaseStruct
    {
        public ITEM_RANK_RATEInfo[] lsData;
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

        public class ITEM_RANK_RATEInfo : BaseStruct
        {
            public Byte Item_Rank_Value;
            public float Item_Rank_Rate;


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
