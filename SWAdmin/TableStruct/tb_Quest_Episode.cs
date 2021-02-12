using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Quest_Episode_Server : BaseStruct
    {
        public tb_Quest_Episode[] lsData;
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

        public class tb_Quest_Episode : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Complete_Bit;
            public String Name = "";
            public UInt32 Chapter_ID;
            public Byte Contents_Type;
            public Byte Progress_Type;
            public Byte Repeat_Value;
            public UInt32 Before_Episode_ID_1;
            public UInt32 Before_Episode_ID_2;
            public UInt32 Before_Episode_ID_3;
            public UInt32 Before_Episode_ID_4;
            public UInt32 Before_Episode_ID_5;
            public UInt32 Before_Episode_ID_6;
            public UInt32 Before_Episode_ID_7;
            public UInt32 Before_Episode_ID_8;
            public UInt32 Before_Episode_ID_9;
            public UInt32 Before_Episode_ID_10;
            public UInt32 Link_Episode_ID_01;
            public UInt32 Link_Episode_ID_02;
            public UInt32 Link_Episode_ID_03;
            public UInt32 Link_Episode_ID_04;
            public UInt32 Link_Episode_ID_05;
            public UInt32 Link_Episode_ID_06;
            public UInt32 Link_Episode_ID_07;
            public UInt32 Link_Episode_ID_08;
            public UInt32 Link_Episode_ID_09;
            public UInt32 Link_Episode_ID_10;
            public UInt32 Time_Limit;
            public Byte Quest_Level;
            public UInt16 Class_Type;
            public Byte Auto_Start;
            public Byte Auto_Start_Event;
            public UInt32 Auto_Start_Event_ID;
            public Byte Start_Object_Type;
            public UInt32 Start_Object_ID;
            public Byte Finish_Type;
            public Byte Finish_Object_Type;
            public UInt32 Finish_Object_ID;
            public UInt32 Field_ID;
            public UInt32 Maze_group_ID;
            public UInt32 Maze_ID_1;
            public UInt32 Maze_ID_2;
            public UInt32 Maze_ID_3;
            public UInt32 Maze_ID_4;
            public UInt32 Sector_ID_1;
            public UInt32 Sector_ID_2;
            public UInt32 Sector_ID_3;
            public UInt32 Sector_ID_4;
            public Byte Give_Up;
            public Byte Add_Object_Type_01;
            public Byte Add_Object_Type_02;
            public UInt32 Add_Object_ID_01;
            public UInt32 Add_Object_ID_02;
            public UInt32 Remove_Item_ID_01;
            public UInt32 Remove_Item_ID_02;
            public UInt32 Remove_Item_ID_03;
            public UInt32 Remove_Item_ID_04;
            public UInt32 Remove_Item_ID_05;
            public UInt32 Remove_Item_Count_01;
            public UInt32 Remove_Item_Count_02;
            public UInt32 Remove_Item_Count_03;
            public UInt32 Remove_Item_Count_04;
            public UInt32 Remove_Item_Count_05;
            public String Quest_Script_Name = "";
            public Byte Episode_Reward_Type;
            public UInt32 Reward_EXP;
            public UInt32 Reward_Money;
            public UInt32 Reward_Ether;
            public UInt32 Reward_BP;
            public UInt32 Reward_Title_01;
            public UInt32 Reward_Title_02;
            public UInt32 Reward_Awakening;
            public Byte Reward_Item_type;
            public UInt32 Reward_Item_ID_01;
            public UInt32 Reward_Item_ID_02;
            public UInt32 Reward_Item_ID_03;
            public UInt32 Reward_Item_ID_04;
            public UInt32 Reward_Item_ID_05;
            public UInt32 Reward_Item_Count_01;
            public UInt32 Reward_Item_Count_02;
            public UInt32 Reward_Item_Count_03;
            public UInt32 Reward_Item_Count_04;
            public UInt32 Reward_Item_Count_05;
            public Byte Select_Reward_Item_type;
            public UInt32 Select_Reward_Item_01;
            public UInt32 Select_Reward_Item_02;
            public UInt32 Select_Reward_Item_03;
            public UInt32 Select_Reward_Item_04;
            public UInt32 Select_Reward_Item_05;
            public UInt32 Select_Reward_Item_Count_01;
            public UInt32 Select_Reward_Item_Count_02;
            public UInt32 Select_Reward_Item_Count_03;
            public UInt32 Select_Reward_Item_Count_04;
            public UInt32 Select_Reward_Item_Count_05;
            public UInt32 Reward_Class_Skill_01;
            public UInt32 Reward_Class_Skill_02;
            public UInt32 Reward_Class_Skill_03;
            public UInt32 Reward_Class_Skill_04;
            public UInt32 Reward_Helper;
            public Byte Condition_Type;
            public UInt32 Condition_ID_01;
            public UInt32 Condition_ID_02;
            public UInt32 Condition_ID_03;
            public UInt32 Condition_ID_04;
            public UInt32 Condition_ID_05;
            public UInt32 Condition_ID_06;
            public UInt32 Condition_ID_07;
            public UInt32 Condition_ID_08;
            public UInt32 Condition_ID_09;
            public UInt32 Condition_ID_10;
            public UInt32 Restore_Item;
            public Byte Save_Quest;
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
