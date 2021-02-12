using System;

namespace SWAdmin.TableStruct
{
    public class TBSKILLServer : BaseStruct
    {
        public SKILLInfo[] lsData;
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

        public class SKILLInfo : BaseStruct
        {
            public UInt32 Skill_Index;
            public String Skill_NameS_String = "";
            public UInt32 Skill_Group;
            public UInt32 Swap_Skill_Index;
            public Byte Skill_LV;
            public Byte Use_Position;
            public Byte Use_Class;
            public Byte Req_Min_LV;
            public Byte Req_Min_AwakeningGrade;
            public Byte Req_Skill_Point;
            public Byte Skill_Max_Level;
            public Byte Req_Consume_Point;
            public UInt32 Req_Prev_Skill_ID;
            public UInt32 Build_Up_Skill_ID;
            public UInt32 Div_GroupID_01;
            public UInt32 Div_GroupID_02;
            public UInt32 Prev_Skill_ID;
            public Byte Skill_SkipPriority_Group;
            public Byte Skill_Type;
            public Byte Passive_Type;
            public Byte Behavior_Condition;
            public UInt16 Passive_Value;
            public float Skill_Basic_Damage;
            public float Skill_Add_Damage_INT;
            public float Skill_Add_Damage_RAT;
            public float Con_SG_Absorb;
            public float SuperArmor_Attack;
            public Byte Target_Damage_Count;
            public UInt16 Skill_Rate_Movement;
            public Byte Monster_Skill_Target_State;
            public Byte Skill_Attribute;
            public Byte Skill_Attribute_Sub;
            public Byte Skill_Cost_Attribute;
            public UInt32 Skill_Cost;
            public Byte Cost_Type;
            public Byte Skill_Direction;
            public Byte Control_Type;
            public Byte Charging_Count;
            public UInt32 Charging_Max_Value;
            public UInt32 Skill_Movement_Value_Min;
            public UInt32 Skill_Movement_Value_Max;
            public Byte Skill_Targeting_Max_Value;
            public UInt16 Skill_Range_Min;
            public UInt16 Skill_Range_Max;
            public Byte Skill_Angle_Value;
            public Byte Skill_Ratation_Type;
            public Byte Use_State;
            public Byte Normal_State;
            public Byte Collision_Check_Type;
            public Byte Action_Conditional_Activation;
            public UInt32 Next_Chain_Skill_ID;
            public Byte Next_Chain_Skill_Rate;
            public UInt32 CoolTime;
            public UInt32 CoolTime_Group;
            public Byte CoolTime_Save;
            public UInt16 CoolTime_Global;
            public UInt16 Bullet_Move_Time;
            public UInt32 Bullet_Life_Time;
            public Byte Bullet_Sync_Type;
            public Byte Agro_Type;
            public UInt16 Agro_Value;
            public UInt16 RankPoint_Value;
            public String Ani_Res_Start_String = "";
            public String Ani_Res_Loop_String = "";
            public String Ani_Res_Extra_String = "";
            public String Ani_Res_End_String = "";
            public Byte Attack_Action_link_Type;
            public UInt32 Ani_Loop_Count;
            public UInt16 Ani_Time;
            public Byte Skill_Motion_Skip_Type;
            public Byte Ani_Processing_Link_Type;
            public UInt16 Ani_Move_Distance;
            public Byte Res_Add_Type;
            public Byte Camera_Lock;
            public Byte Target_Type;
            public UInt32 Time_Value_01;
            public UInt32 Time_Value_02;
            public UInt32 Time_Value_03;
            public UInt32 Time_Value_04;


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
