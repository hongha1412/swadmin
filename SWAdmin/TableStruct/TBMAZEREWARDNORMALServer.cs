using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDNORMALServer : BaseStruct
    {
        public MAZEREWARD_NORMALInfo[] lsData;
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

        public class MAZEREWARD_NORMALInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt32 Count;
            public UInt32 Combo_Score;
            public UInt32 Climax_Score;
            public UInt32 Erosion_Score;
            public UInt32 Collaboration_Score;
            public UInt32 Damage_Score;
            public UInt32 VictimHit_Rate;


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
