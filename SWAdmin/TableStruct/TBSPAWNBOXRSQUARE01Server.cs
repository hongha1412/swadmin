using System;

namespace SWAdmin.TableStruct
{
    public class TBSPAWNBOXRSQUARE01Server : BaseStruct
    {
        public SPAWNBOX_RSQUARE_01Info[] lsData;
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

        public class SPAWNBOX_RSQUARE_01Info : BaseStruct
        {
            public Byte ID;
            public UInt16 SpawnBox_ID;
            public UInt32 Monster_ID;
            public Byte Monster_Count;
            public UInt32 NextSpawn_Deley;


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
