using System;

namespace SWAdmin.TableStruct
{
    public class TBMONSTEREXPServer : BaseStruct
    {
        public MONSTER_EXPInfo[] lsData;
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

        public class MONSTER_EXPInfo : BaseStruct
        {
            public Byte ID;
            public Byte Level;
            public Int32 EXP_Slave;
            public Int32 EXP_Normal;
            public Int32 EXP_Elite;
            public Int32 EXP_Named;
            public Int32 EXP_Boss;
            public Int32 EXP_Raid;
            public Int32 EXP_Summon;


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
