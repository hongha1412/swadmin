using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBCharacterInfoServer : BaseStruct
    {
        public TBCharacterInfo[] lsData;
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

        public class TBCharacterInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Character_ID;
            public UInt16 Character_Group_ID;
            public String PC_Code_Name = "";
            public UInt32 Item_ID_Weapon_01;
            public UInt32 Default_Cloth_ID_01;
            public UInt32 Default_Cloth_ID_02;
            public UInt32 Default_Cloth_ID_03;
            public UInt32 Default_Cloth_ID_04;
            public UInt16 Default_Provide_Item;
            public UInt16 District_ID;
            public UInt16 District_Position_X;
            public UInt16 District_Position_Y;
            public UInt16 District_Position_Z;
            public UInt16 Maze_ID;
            public UInt32 Maze_Spawnbox_ID;
            public UInt32 Character_Start_Quest_ID;
            public UInt32 Character_Skip_Quest_ID;
            public Byte Character_Status_Type;
            public UInt32 Character_Status;
            public UInt16 Char_Height_Value;
            public UInt16 Nomal_Walk_Speed;
            public UInt16 Nomal_Run_Speed;
            public UInt16 Nomal_JumpMove_Speed;
            public UInt16 Battle_Run_Speed;
            public UInt16 Battle_JumpMove_Speed;
            public UInt16 Battle_Dash_Speed;
            public Single Battle_BackMove_Ratio;
            public Byte PC_Faction;
            public UInt16 Char_CollisionRadius;
            public UInt16 Char_CollisionHeight;
            public UInt16 Char_RealHeight;
            public UInt32 Default_Skill_ID_01;
            public UInt32 Default_Skill_ID_02;
            public UInt32 Default_Skill_ID_03;
            public UInt32 Default_Skill_ID_04;
            public UInt32 Default_Skill_ID_05;
            public UInt32 Default_Skill_ID_06;
            public UInt32 Default_Skill_ID_07;
            public UInt32 Default_Skill_ID_08;
            public UInt32 Default_Skill_ID_09;
            public UInt32 Default_Skill_ID_10;
            public UInt32 Default_Skill_ID_11;
            public UInt32 Default_Skill_ID_12;
            public UInt32 Default_Skill_ID_13;
            public UInt32 Default_Skill_ID_14;
            public UInt32 Default_Skill_ID_15;
            public UInt32 Default_Skill_ID_16;
            public UInt32 Default_Skill_ID_17;
            public UInt32 Default_Skill_ID_18;
            public UInt32 Default_Skill_ID_19;
            public UInt32 Default_Skill_ID_20;
            public Byte Set_Quick_Slot_ID_01;
            public Byte Set_Quick_Slot_ID_02;
            public Byte Set_Quick_Slot_ID_03;
            public Byte Set_Quick_Slot_ID_04;
            public Byte Set_Quick_Slot_ID_05;
            public Byte Set_Quick_Slot_ID_06;
            public Byte Set_Quick_Slot_ID_07;
            public Byte Set_Quick_Slot_ID_08;
            public Byte Set_Quick_Slot_ID_09;
            public Byte Set_Quick_Slot_ID_10;
            public Byte Set_Quick_Slot_ID_11;
            public Byte Set_Quick_Slot_ID_12;
            public Byte Set_Quick_Slot_ID_13;
            public Byte Set_Quick_Slot_ID_14;
            public Byte Set_Quick_Slot_ID_15;
            public Byte Set_Quick_Slot_ID_16;
            public Byte Set_Quick_Slot_ID_17;
            public Byte Set_Quick_Slot_ID_18;
            public Byte Set_Quick_Slot_ID_19;
            public Byte Set_Quick_Slot_ID_20;
            public UInt16 Set_Gesture_Slot_ID_01;
            public UInt16 Set_Gesture_Slot_ID_02;
            public UInt16 Set_Gesture_Slot_ID_03;
            public UInt16 Set_Gesture_Slot_ID_04;
            public UInt16 Set_Gesture_Slot_ID_05;
            public UInt16 Set_Gesture_Slot_ID_06;
            public Single Akashic_Active_Time;
            public Byte Character_On_Type;
            public Byte Character_On;

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
