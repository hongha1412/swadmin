using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBAchievementClient : BaseStruct
    {
        public AchievementInfo[] lsData;
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

        public class AchievementInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Achievement_Category;
            public UInt16 Achievement_Group;
            public Byte Achievement_Order;
            public UInt16 Complete_Bit;
            public String Achievement_icon = "";
            public UInt16 Achievement_type;
            public UInt32 Unknown1;
            public UInt32 Unknown2;
            public UInt32 Achievement_count;
            public UInt32 achievement_Reward_gold;
            public UInt32 achievement_Reward_Ether;
            public UInt32 achievement_Reward_BP;
            public UInt32 achievement_Reward_title_1;
            public UInt32 achievement_Reward_title_2;
            public Byte achievement_Reward_item_type_1;
            public Byte achievement_Reward_item_type_2;
            public UInt32 achievement_Reward_item_1;
            public UInt32 achievement_Reward_item_2;
            public Byte achievement_Reward_item_count_1;
            public Byte achievement_Reward_item_count_2;

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
