using System;

namespace SWAdmin.TableStruct
{
    public class TBLEAGUESKILLServer : BaseStruct
    {
        public LEAGUE_SKILLInfo[] lsData;
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

        public class LEAGUE_SKILLInfo : BaseStruct
        {
            public UInt32 League_Skill_Index;
            public UInt32 League_Skill_Type;
            public UInt32 League_Skill_Level;
            public UInt32 League_Skill_Level_Max;
            public UInt32 League_Skill_Group;
            public UInt32 League_Next_Skill;
            public UInt32 League_Get_Skill_Level;
            public UInt32 League_Skill_Effect_Type;
            public UInt32 League_Skill_Apply_Type;
            public UInt32 League_Skill_Apply_Value;
            public UInt32 League_Skill_Need_Point;
            public UInt32 League_Skill_Need_Gold;


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
