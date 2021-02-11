using System;

namespace SWAdmin.TableStruct
{
    public class TBDROPRATEMEMBERServer : BaseStruct
    {
        public DROPRATE_MEMBERInfo[] lsData;
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

        public class DROPRATE_MEMBERInfo : BaseStruct
        {
            public Byte DropRate_Party_Member;
            public float DropRate_Member_Value;


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
