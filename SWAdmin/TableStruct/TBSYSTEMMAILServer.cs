using System;

namespace SWAdmin.TableStruct
{
    public class TBSYSTEMMAILServer : BaseStruct
    {
        public SYSTEMMAILInfo[] lsData;
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

        public class SYSTEMMAILInfo : BaseStruct
        {
            public Byte SysMail_ID;
            public UInt16 SysMail_TypeID;
            public UInt16 SysMail_TypeTargetID;


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
