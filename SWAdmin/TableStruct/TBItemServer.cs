using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBItemServer : BaseStruct
    {
        public ItemInfo[] lsData;
        public SWString md5_ = new SWString();

        public TBItemServer() { }

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

        public class ItemInfo : BaseStruct
        {
            public UInt32 Item_ID;
            public UInt32 Item_Classify_Index;
            public Byte Item_Rank;
            public UInt16 Item_Lv;
            public UInt32 Sell_Price;
            public UInt32 Buy_Price;
            public UInt32 Recycle_Sell_Price;
            public UInt32 Recycle_Buy_Price;
            public UInt16 Item_Stack_Max;
            public Byte Item_Bind_Type;
            public UInt32 Item_Model_ID;
            public String Item_NameS = "";
            public UInt16 Item_Limit_Lv;
            public Byte Item_Limit_Class;
            public Byte Item_Limit_Sell_Type;
            public Byte Item_Sub_Type;
            public Byte Item_CostumeSet;
            public UInt32 Item_CostumeSet_ID;
            public String Item_Slot_Disable = "";
            public Byte Item_Endurance_Max;
            public Byte Item_Use_Value;
            public UInt32 Item_physical_Attack_Min;
            public UInt32 Item_physical_Attack;
            public UInt32 Item_Magic_Attack;
            public UInt32 Item_physical_Defense_Min;
            public UInt32 Item_physical_Defense;
            public UInt32 Item_Magic_Defense;
            public Byte Option_Class_1;
            public Byte Option_Class_2;
            public Byte Option_Class_3;
            public Byte Option_Class_4;
            public Byte Option_Class_5;
            public UInt32 S_Option_Type_1;
            public UInt32 S_Option_Type_2;
            public UInt32 S_Option_Type_3;
            public UInt32 S_Option_Type_4;
            public UInt32 S_Option_Type_5;
            public Int32 S_Option_Value_1;
            public Int32 S_Option_Value_2;
            public Int32 S_Option_Value_3;
            public Int32 S_Option_Value_4;
            public Int32 S_Option_Value_5;
            public UInt32 Item_Ex_Option_ID;
            public UInt32 Item_Socket_ID;
            public UInt32 Item_SetItem_ID;
            public UInt16 Item_Reinforce_ID;
            public UInt32 Item_Reinforce_Option_ID;
            public UInt32 Item_Title_ID;
            public UInt32 Item_Evolution_ID;
            public UInt16 Item_Disassemble_ID;
            public UInt32 Furniture_ID;
            public UInt16 Cooltime_Group;
            public UInt32 Cooltime_Value;
            public Byte Cooltime_Save;
            public UInt16 Item_Effect_Type;
            public UInt32 Item_Effect_ID;
            public Byte Item_Cash;
            public Byte Item_Use_Period_Type;
            public UInt32 Item_Use_Period_Value;
            public Byte Sealing_Cnt;
            public Byte Break_Cnt;
            public UInt32 Item_SimilarGroup_ID;
            public UInt32 RepackageItem_ID;

            public ItemInfo() { }

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
