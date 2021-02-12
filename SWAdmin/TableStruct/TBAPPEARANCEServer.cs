using System;

namespace SWAdmin.TableStruct
{
    public class TBAPPEARANCEServer : BaseStruct
    {
        public APPEARANCEInfo[] lsData;
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

        public class APPEARANCEInfo : BaseStruct
        {
            public UInt32 Appearance_ID;
            public Byte Appearance_Classify;
            public Byte Appearance_Type;
            public Byte Appearance_Class;


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
