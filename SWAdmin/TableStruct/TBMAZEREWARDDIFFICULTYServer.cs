using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDDIFFICULTYServer : BaseStruct
    {
        public MAZEREWARD_DIFFICULTYInfo[] lsData;
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

        public class MAZEREWARD_DIFFICULTYInfo : BaseStruct
        {
            public Byte ID;
            public Byte Difficulty;
            public float Difficulty_Value;


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
