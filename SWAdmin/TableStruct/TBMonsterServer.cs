using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBMonsterServer : BaseStruct
    {
        public MonsterInfo[] lsData;
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

        public class MonsterInfo : BaseStruct
        {
            public UInt32 ID;
            public String Monster_Code_Name = "";
            public String Monster_Name_D = "";
            public UInt32 Monster_Parts_ID_02;
            public UInt32 Monster_Parts_ID_03;
            public Byte Summon_Hit;
            public Byte Monster_Faction;
            public UInt32 Quest_Group_1;
            public UInt32 Quest_Group_2;
            public UInt32 Quest_Group_3;
            public UInt32 Quest_Group_4;
            public UInt32 Quest_Group_5;
            public UInt32 Mission_Group_1;
            public UInt32 Mission_Group_2;
            public UInt32 Mission_Group_3;
            public Byte Monster_Lv;
            public float Exp;
            public UInt32 Moster_Kill_Score;
            public Byte Monster_Rank;
            public Byte Monster_Type;
            public Byte Monster_Flag;
            public Byte Monster_ClearCondition_Type;
            public Byte Object_MaxDamage_Value;
            public String Object_Default_Ani_File = "";
            public String Object_Open_Ani_File = "";
            public Byte Monster_Element;
            public Byte Monster_Aggression_Type;
            public UInt32 Melee_Skill_Inclination;
            public UInt32 Range_Skill_Inclination;
            public UInt32 Heal_Skill_Inclination;
            public UInt32 Other_Skill_Inclination;
            public float Protection_Aggro_Ratio;
            public UInt32 Monster_Sight;
            public Byte Monster_WeightRank;
            public Byte Monster_Defence_Type;
            public Byte Monster_DMGAction_Type;
            public Byte Monster_HeadAction_Type;
            public Byte Monster_Defence_Direction_Type;
            public UInt16 Monster_Walk_Speed;
            public UInt16 Monster_Run_Speed;
            public UInt16 Monster_Turn_Speed;
            public UInt16 Monster_Gaze_Speed;
            public Byte Monster_Status_Type;
            public UInt32 Monster_Status_ID;
            public UInt16 Monster_Weapon_ID;
            public Byte Monster_BattleMode_Type;
            public String Monster_AI_ID = "";
            public Byte Monster_AI_Type;
            public Byte Monster_Death_Type;
            public String Monster_Special_Damage = "";
            public Byte Monster_Default_Action_Type;
            public UInt16 Monster_NormalStand_Type;
            public Byte Monster_Default_Action_Type_01;
            public Byte Monster_Default_Action_Type_02;
            public Byte Monster_Default_Action_Type_03;
            public UInt16 Monster_NormalStand_Type_01;
            public String Monster_Switching_01_AI = "";
            public String Monster_Switching_02_AI = "";
            public String Monster_Switching_03_AI = "";
            public Byte Monster_AI_Type_01;
            public Byte Monster_AI_Type_02;
            public Byte Monster_AI_Type_03;
            public String Monster_Special_01_Damage = "";
            public String Monster_Special_02_Damage = "";
            public String Monster_Special_03_Damage = "";
            public Byte Monster_Switching_AI_Condition_01;
            public Byte Monster_Switching_AI_Condition_02;
            public Byte Monster_Switching_AI_Condition_03;
            public UInt32 Monster_Switching_AI_Value_01;
            public UInt32 Monster_Switching_AI_Value2_02;
            public UInt32 Monster_Switching_AI_Value_03;
            public Byte Monster_Switching_AI_Step_01;
            public Byte Monster_Switching_AI_Step_02;
            public Byte Monster_Switching_AI_Step_03;
            public String Monster_Switching_01_Action = "";
            public String Monster_Switching_02_Action = "";
            public String Monster_Switching_03_Action = "";
            public UInt16 Monster_NormalStand_Type_02;
            public UInt16 Monster_NormalStand_Type_03;
            public UInt32 Monster_Skill1_ID;
            public UInt32 Monster_Skill2_ID;
            public UInt32 Monster_Skill3_ID;
            public UInt32 Monster_Skill4_ID;
            public UInt32 Monster_Skill5_ID;
            public UInt32 Monster_Skill6_ID;
            public UInt32 Monster_Skill7_ID;
            public UInt32 Monster_Skill8_ID;
            public UInt32 Monster_Skill9_ID;
            public UInt32 Monster_Skill10_ID;
            public UInt32 Monster_Drop_ID;
            public UInt32 Monster_Hit_Drop_ID;
            public float Monster_Scale;
            public UInt16 Monster_CollisionRadius;
            public UInt16 Monster_CollisionHeight;
            public UInt16 Monster_RealHeight;
            public UInt32 Monster_Party_Revise;
            public Byte Monster_SA_Type;
            public Int32 HP_Max_INT_Value;
            public Int32 SG_Max_INT_Value;
            public Int32 PATK_Max_INT_Value;
            public Int32 MATK_Max_INT_Value;
            public Int32 PDPR_RAT_Value;
            public Int32 MDPR_RAT_Value;
            public Int32 PDEF_INT_Value;
            public Int32 MDEF_INT_Value;
            public Int32 PAR_INT_Value;
            public Int32 MAR_INT_Value;
            public Int32 PARP_INT_Value;
            public Int32 MARP_INT_Value;
            public Int32 ADR_INT_Value;
            public Int32 PCP_INT_Value;
            public Int32 MCP_INT_Value;
            public Int32 PCRP_INT_Value;
            public Int32 MCRP_INT_Value;
            public Int32 PCA_INT_Value;
            public Int32 MCA_INT_Value;
            public Int32 DAR_INT_Value;
            public Int32 PDSR_INT_Value;
            public Int32 MDSR_INT_Value;
            public Int32 AtkPower_Light_INT_Value;
            public Int32 AtkPower_Dark_INT_Value;
            public Int32 AtkPower_Blue_INT_Value;
            public Int32 AtkPower_Red_INT_Value;
            public Int32 AtkPower_White_INT_Value;
            public Int32 AtkPower_Green_INT_Value;
            public Int32 Resist_Light_INT_Value;
            public Int32 Resist_Dark_INT_Value;
            public Int32 Resist_Blue_INT_Value;
            public Int32 Resist_Red_INT_Value;
            public Int32 Resist_White_INT_Value;
            public Int32 Resist_Green_INT_Value;
            public Int32 Res_Burn_INT_Value;
            public Int32 Res_Poision_INT_Value;
            public Int32 Res_Shcok_INT_Value;
            public Int32 Res_Bleed_INT_Value;
            public Int32 Res_Stun_INT_Value;
            public Int32 Res_Paralysis_INT_Value;
            public Int32 Res_Sleep_INT_Value;
            public Int32 Res_Freeze_INT_Value;
            public Int32 Res_Charm_INT_Value;
            public Int32 Res_Confusion_INT_Value;
            public Int32 Res_Silence_INT_Value;
            public Int32 Res_Weak_INT_Value;
            public Byte IS_Item_Rate;

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
