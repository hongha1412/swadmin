using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBItemEvolutionServer : BaseStruct
    {
        public ItemEvolutionInfo[] lsData;
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

        public class ItemEvolutionInfo : BaseStruct
        {
            public UInt32 Evolution_ID;
            public Byte Result_Sum;
            public UInt16 Success_Rate;
            public UInt32 Need_Item;
            public UInt32 Item_Count;
            public UInt32 Need_Ether;
            public UInt32 Need_Gold;
            public UInt32 Need_BP;
            public UInt32 Item_01;
            public UInt32 Item_02;
            public UInt32 Item_03;
            public UInt32 Item_04;
            public UInt32 Item_05;
            public UInt32 Item_06;
            public UInt16 Rate_01;
            public UInt16 Rate_02;
            public UInt16 Rate_03;
            public UInt16 Rate_04;
            public UInt16 Rate_05;
            public UInt16 Rate_06;

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
