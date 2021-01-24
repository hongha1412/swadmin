using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBDailyMissionServer : BaseStruct
    {
        public DailyMissionInfo[] lsData;
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

        public class DailyMissionInfo : BaseStruct
        {
            public UInt32 Mission_ID;
            public Byte Mission_Type;
            public String Name = "";
            public UInt32 District_ID;
            public Byte Finish_Type;
            public Byte Target_Type;
            public UInt32 Target_ID;
            public Byte Target_Faction;
            public UInt32 Condition_Type;
            public UInt32 Condition_Value;
            public Byte Condition_Class;
            public UInt32 Condition_Title_01;
            public UInt32 Condition_Title_02;
            public Byte Condition_Count;
            public Byte Mission_Count;
            public String Date_Start = "";
            public String Date_End = "";
            public UInt32 Reward_Item_Id_01;
            public UInt32 Reward_Item_Id_02;
            public UInt32 Reward_Item_Id_03;
            public UInt32 Reward_Item_Id_04;
            public Byte Reward_Item_Count_01;
            public Byte Reward_Item_Count_02;
            public Byte Reward_Item_Count_03;
            public Byte Reward_Item_Count_04;

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
