using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDSOULVAPERServer : BaseStruct
    {
        public MAZEREWARD_SOULVAPERInfo[] lsData;
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

        public class MAZEREWARD_SOULVAPERInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt32 SoulVaper_Count;
            public UInt32 SoulVaper_Score;


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
