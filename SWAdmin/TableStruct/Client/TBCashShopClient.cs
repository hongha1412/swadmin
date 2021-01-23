using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBCashShopClient : BaseStruct
    {
        public CashShopInfo[] lsData;
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

        public class CashShopInfo : BaseStruct
        {
            public UInt32 Shop_Index;
            public UInt16 MainTab_ID;
            public UInt16 SubTab_ID;
            public Byte Sell_Active;
            public UInt32 SellItem_ID;
            public Byte Need_Slot;
            public Byte Sell_Type;
            public Byte Item_Gift;
            public UInt32 Sell_priority;
            public Byte Limit_Type;
            public String Limit_Start_Date = "";
            public String Limit_End_Date = "";
            public Byte Sell_Number_Type;
            public UInt16 Sell_Number_Value;
            public Byte Sell_Level;
            public UInt16 BillingInfo_ID;
            public UInt16 Mileage_ID;
            public Byte Hot_Icon;
            public Byte New_Icon;
            public String Unknown1 = "";

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
