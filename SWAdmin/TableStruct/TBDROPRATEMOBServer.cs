using System;

namespace SWAdmin.TableStruct
{
    public class TBDROPRATEMOBServer : BaseStruct
    {
        public DROPRATE_MOBInfo[] lsData;
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

        public class DROPRATE_MOBInfo : BaseStruct
        {
            public Byte DropRate_Mob_LevelInterval;
            public float DropRate_MobInterval_Value;


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
