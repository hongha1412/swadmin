using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBItemRandomBoxServer : BaseStruct
    {
        public ItemRandomBoxInfo[] lsData;
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

        public class ItemRandomBoxInfo : BaseStruct
        {
            public UInt32 RandomBox_ID;
            public Byte Give_Count;
            public UInt32 Rate_Sum;
            public UInt32 RB_Gold;
            public UInt16 Gold_Rate;
            public UInt16 BP_Rate;
            public UInt16 Ether_Rate;
            public UInt16 Rate_01;
            public UInt16 Rate_02;
            public UInt16 Rate_03;
            public UInt16 Rate_04;
            public UInt16 Rate_05;
            public UInt16 Rate_06;
            public UInt16 Rate_07;
            public UInt16 Rate_08;
            public UInt16 Rate_09;
            public UInt16 Rate_10;
            public UInt16 Rate_11;
            public UInt16 Rate_12;
            public UInt16 Rate_13;
            public UInt16 Rate_14;
            public UInt16 Rate_15;
            public UInt32 RB_BP;
            public UInt32 RB_Ether;
            public UInt32 Item_01;
            public UInt32 Item_02;
            public UInt32 Item_03;
            public UInt32 Item_04;
            public UInt32 Item_05;
            public UInt32 Item_06;
            public UInt32 Item_07;
            public UInt32 Item_08;
            public UInt32 Item_09;
            public UInt32 Item_10;
            public UInt32 Item_11;
            public UInt32 Item_12;
            public UInt32 Item_13;
            public UInt32 Item_14;
            public UInt32 Item_15;
            public UInt32 Count_01;
            public UInt32 Count_02;
            public UInt32 Count_03;
            public UInt32 Count_04;
            public UInt32 Count_05;
            public UInt32 Count_06;
            public UInt32 Count_07;
            public UInt32 Count_08;
            public UInt32 Count_09;
            public UInt32 Count_10;
            public UInt32 Count_11;
            public UInt32 Count_12;
            public UInt32 Count_13;
            public UInt32 Count_14;
            public UInt32 Count_15;

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
