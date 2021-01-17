using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBShopServer : BaseStruct
    {
        public ShopInfo[] lsData;
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

        public class ShopInfo : BaseStruct
        {
            public UInt32 Shop_Index;
            public UInt32 Group_ID;
            public Byte Sell_Active;
            public UInt32 SellItem_ID;
            public Byte Need_Slot;
            public Byte Customer_Grade;
            public Byte Limit_Type;
            public Byte Period_Type;
            public Byte Day_Limit;
            public Byte Sell_Type;
            public String Start_Date = "";
            public String End_Date = "";
            public Byte Price_Type;
            public UInt16 Item_Count;
            public UInt32 Price_Base;
            public UInt32 Price_1day;
            public UInt32 Price_7day;
            public UInt32 Price_15day;
            public UInt32 Price_30day;
            public Byte Sell_AddIcon;
            public Byte Item_Gift;
            public UInt32 Sell_priority;

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
