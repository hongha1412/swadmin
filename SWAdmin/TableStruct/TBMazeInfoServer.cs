using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBMazeInfoServer : BaseStruct
    {
        public MazeInfo[] lsData;
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

        public class MazeInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Maze_Type;
            public UInt16 Maze_Group;
            public Byte Req_Min_Lv;
            public Byte Admission_Member;
            public UInt16 Fatigue_Point;
            public UInt16 Maze_Enter_Count_Group;
            public Byte Maze_Enter_Count_Type;
            public Byte Maze_Enter_Count;
            public Byte Maze_Enter_Count_PC_Room;
            public Byte Maze_Enter_Plus_Day;
            public Byte Maze_Enter_Plus_Value;
            public Byte Helper_Summon_Check;
            public UInt32 NeedQuest_ID;
            public UInt32 NeedItem_ID;
            public Byte NeedItem_Value;
            public Byte Revival_Type;
            public Byte Revival_Item_Count;
            public Byte Maze_Difficulty_Type;
            public Byte Layer_BitMask;
            public Byte Maze_Episode_No;
            public Byte Clear_Cal_Type;
            public Byte Clear_Con_Type_01;
            public Byte Clear_Con_Type_02;
            public Byte Clear_Con_Type_03;
            public UInt32 Clear_Con_Value_01;
            public UInt32 Clear_Con_Value_02;
            public UInt32 Clear_Con_Value_03;
            public UInt32 Check_Clear_Maze;
            public UInt16 Open_Maze_ID_01;
            public UInt16 Open_Maze_Group_ID;
            public UInt16 Maze_ClearTime;
            public UInt32 Maze_Reward_EXP;
            public UInt32 Maze_Reward_Money;
            public UInt16 Maze_Bind_Rate;
            public String ServerMap = "";
            public String Server_SceneScript_File = "";
            public UInt32 Maze_SceneAttack_Monster;
            public float Share_Point_Ratio;
            public String UI_String = "";
            public UInt16 Maze_Portal_ID;
            public UInt32 Maze_Start_X;
            public UInt32 Maze_Start_Y;
            public UInt32 Maze_Size_X;
            public UInt32 Maze_Size_Y;
            public UInt16 Escape_District_ID;
            public UInt32 Escape_StartBox_ID;
            public UInt32 Ing_Quest_ID_01;
            public UInt32 Ing_Quest_ID_02;
            public UInt32 Ing_Quest_ID_03;
            public UInt32 Ing_Quest_ID_04;
            public UInt32 Ing_Quest_ID_05;
            public Byte Arkashic_Use;
            public Byte Potion_Limit;
            public UInt32 WarpOrb_Item_ID;
            public Byte Maze_Re_Enter;

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
