using System;

namespace SWAdmin.TableStruct
{
    public class TBMONSTERBROKENPARTSServer : BaseStruct
    {
        public MONSTER_BROKEN_PARTSInfo[] lsData;
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

        public class MONSTER_BROKEN_PARTSInfo : BaseStruct
        {
            public UInt32 ID;
            public String Anim_File_String = "";
            public UInt32 Type;
            public UInt32 HP_Pct;
            public UInt32 Spawn_Monster_ID;
            public String Spawn_Ani_String = "";
            public UInt32 Link_Parts;
            public UInt32 Link_Monster_ID;
            public String Link_Monster_Parts_Ani_String = "";


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
