using System;

namespace SWAdmin.TableStruct
{
    public class TBBROACHCOMPOSERANKServer : BaseStruct
    {
        public BROACHCOMPOSE_RANKInfo[] lsData;
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

        public class BROACHCOMPOSE_RANKInfo : BaseStruct
        {
            public UInt16 Compose_Value;
            public UInt16 Bit_Broach_Rate;
            public UInt16 Kilo_Broach_Rate;
            public UInt16 Mega_Broach_Rate;
            public UInt16 Giga_Broach_Rate;
            public UInt16 Tera_Broach_Rate;


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
