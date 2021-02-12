using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDREVISIONServer : BaseStruct
    {
        public MAZEREWARD_REVISIONInfo[] lsData;
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

        public class MAZEREWARD_REVISIONInfo : BaseStruct
        {
            public UInt16 Character_ID;
            public float Revision_Value;
            public float Revision_Value_Thething;


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
