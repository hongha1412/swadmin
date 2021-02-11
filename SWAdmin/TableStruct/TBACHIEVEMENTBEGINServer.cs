using System;

namespace SWAdmin.TableStruct
{
    public class TBACHIEVEMENTBEGINServer : BaseStruct
    {
        public ACHIEVEMENT_BEGINInfo[] lsData;
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

        public class ACHIEVEMENT_BEGINInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt32 Achievement_ID;
            public Byte Achievement_Open_Lv;


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
