using System;

namespace SWAdmin.TableStruct
{
    public class TBMONSTERPARTSServer : BaseStruct
    {
        public MONSTER_PARTSInfo[] lsData;
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

        public class MONSTER_PARTSInfo : BaseStruct
        {
            public UInt32 ID;
            public String Anim_File_String = "";


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
