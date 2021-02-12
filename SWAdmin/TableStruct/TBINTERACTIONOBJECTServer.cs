using System;

namespace SWAdmin.TableStruct
{
    public class TBINTERACTIONOBJECTServer : BaseStruct
    {
        public INTERACTION_OBJECTInfo[] lsData;
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

        public class INTERACTION_OBJECTInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Object_type;
            public Byte Private_activate;
            public UInt32 Act_Delay_time;
            public Byte Resource_Type;
            public String FileName_String = "";
            public Byte Enable_State;
            public Byte Show_Sight;
            public Byte Change_Show_Sights;
            public UInt32 Show_Quest_ID;
            public UInt32 Show_Condition_Quest_ID;
            public UInt32 Show_Condition_Class_ID;
            public UInt32 Check_Item_ID;
            public UInt32 Check_Item_Count;
            public UInt32 Check_Quest_ID;
            public UInt32 Check_Quest_Condition_ID;
            public Int16 Interaction_Count_Min;
            public Int16 Interaction_Count_Max;
            public UInt32 Interaction_CoolTime;
            public UInt32 Interaction_Range;
            public Byte Interaction_Delete;
            public UInt32 Remove_Item_ID;
            public UInt32 Remove_Item_Count;
            public UInt32 Add_Item_ID;
            public UInt32 Add_Item_Count;
            public UInt16 Respawn_Value_Max;
            public UInt32 Respawn_Delay_Time;
            public UInt32 Add_Random_Item_ID;
            public UInt32 Object_Link_Aura;
            public Byte Public_Quest_Check;
            public String Script_String = "";


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
