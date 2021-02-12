using System;

namespace SWAdmin.TableStruct
{
    public class TBBROACHCOMPOSETYPEServer : BaseStruct
    {
        public BROACHCOMPOSE_TYPEInfo[] lsData;
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

        public class BROACHCOMPOSE_TYPEInfo : BaseStruct
        {
            public UInt16 Broach_Rank_Value;
            public UInt16 Result_Type_Attack;
            public UInt16 Result_Type_Defence;
            public UInt16 Result_Type_Function;


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
