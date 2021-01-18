using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBCashBillingInfoServer : BaseStruct
    {
        public CashBillingInfo[] lsData;
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

        public class CashBillingInfo : BaseStruct
        {
            public UInt16 ID;
            public String Billing_Code_1st = "";
            public UInt32 Item_ID_1st;
            public UInt32 Item_ID_2nd;
            public UInt32 Item_ID_3rd;
            public UInt32 Item_ID_4th;
            public UInt32 Item_ID_5th;
            public UInt32 Value_1st;
            public UInt32 Value_2nd;
            public UInt32 Value_3rd;
            public UInt32 Value_4th;
            public UInt32 Value_5th;
            public UInt32 B_Price_1st;
            public UInt32 B_Price_2nd;
            public UInt32 B_Price_3rd;
            public UInt32 B_Price_4th;
            public UInt32 B_Price_5th;
            public UInt32 S_Price_1st;
            public UInt32 S_Price_2nd;
            public UInt32 S_Price_3rd;
            public UInt32 S_Price_4th;
            public UInt32 S_Price_5th;
            public String Billing_Code_2nd = "";
            public String Billing_Code_3rd = "";
            public String Billing_Code_4th = "";
            public String Billing_Code_5th = "";

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
