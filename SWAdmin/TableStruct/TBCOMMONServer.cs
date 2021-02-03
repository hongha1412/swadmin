using System;

namespace SWAdmin.TableStruct
{
    public class TBCOMMONServer : BaseStruct
    {
        public COMMONInfo[] lsData;
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

        public class COMMONInfo : BaseStruct
        {
            public UInt32 Define_ID;
public String Key_String = "";
public float Value;


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
