using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBCashShopTabServer : BaseStruct
    {
        public CashTabShopInfo[] lsData;
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

        public class CashTabShopInfo : BaseStruct
        {
            public UInt16 MainTab_ID_INFO;
            public UInt16 MainTab_ORDER;
            public UInt16 SubTab_ID_INFO_01;
            public UInt16 SubTab_ORDER_01;
            public UInt16 SubTab_ID_INFO_02;
            public UInt16 SubTab_ORDER_02;
            public UInt16 SubTab_ID_INFO_03;
            public UInt16 SubTab_ORDER_03;
            public UInt16 SubTab_ID_INFO_04;
            public UInt16 SubTab_ORDER_04;
            public UInt16 SubTab_ID_INFO_05;
            public UInt16 SubTab_ORDER_05;
            public UInt16 SubTab_ID_INFO_06;
            public UInt16 SubTab_ORDER_06;
            public UInt16 SubTab_ID_INFO_07;
            public UInt16 SubTab_ORDER_07;
            public UInt16 SubTab_ID_INFO_08;
            public UInt16 SubTab_ORDER_08;
            public UInt16 SubTab_ID_INFO_09;
            public UInt16 SubTab_ORDER_09;
            public UInt16 SubTab_ID_INFO_10;
            public UInt16 SubTab_ORDER_10;

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
