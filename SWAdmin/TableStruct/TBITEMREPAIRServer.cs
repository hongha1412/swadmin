using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMREPAIRServer : BaseStruct
    {
        public ITEM_REPAIRInfo[] lsData;
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

        public class ITEM_REPAIRInfo : BaseStruct
        {
            public UInt32 Index;
            public float Weapon_NPC_Cost_Lv;
            public float Weapon_NPC_Cost_Dur;
            public float Weapon_NPC_Cost_Grade;
            public float Weapon_Item_Cost_Lv;
            public float Weapon_Item_Cost_Dur;
            public float Weapon_Item_Cost_Grade;
            public float Sub_Weapon_NPC_Cost_Lv;
            public float Sub_Weapon_NPC_Cost_Dur;
            public float Sub_Weapon_NPC_Cost_Grade;
            public float Sub_Weapon_Item_Cost_Lv;
            public float Sub_Weapon_Item_Cost_Dur;
            public float Sub_Weapon_Item_Cost_Grade;
            public float Gear_NPC_Cost_Lv;
            public float Gear_NPC_Cost_Dur;
            public float Gear_NPC_Cost_Grade;
            public float Gear_Item_Cost_Lv;
            public float Gear_Item_Cost_Dur;
            public float Gear_Item_Cost_Grade;
            public float Dur_Penalty;


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
