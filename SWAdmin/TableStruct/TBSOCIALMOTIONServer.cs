using System;

namespace SWAdmin.TableStruct
{
    public class TBSOCIALMOTIONServer : BaseStruct
    {
        public SOCIAL_MOTIONInfo[] lsData;
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

        public class SOCIAL_MOTIONInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 Social_Item_ID;
            public Byte Class_Type;


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
