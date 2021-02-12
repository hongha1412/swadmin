using System;

namespace SWAdmin.TableStruct
{
    public class TBLEAGUEINFOServer : BaseStruct
    {
        public LEAGUE_INFOInfo[] lsData;
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

        public class LEAGUE_INFOInfo : BaseStruct
        {
            public UInt32 League_Info_ID;
            public UInt32 League_Level;
            public UInt32 Need_Exp;
            public UInt32 League_Member;
            public UInt32 League_Inventory;
            public UInt32 League_Skill_Get_Point;
            public UInt32 Day_Exp_Get_Point;


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
