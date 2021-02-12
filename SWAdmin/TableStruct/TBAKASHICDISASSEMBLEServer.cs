using System;

namespace SWAdmin.TableStruct
{
    public class TBAKASHICDISASSEMBLEServer : BaseStruct
    {
        public AKASHIC_DISASSEMBLEInfo[] lsData;
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

        public class AKASHIC_DISASSEMBLEInfo : BaseStruct
        {
            public UInt32 Dis_Index;
            public UInt16 Dis_Rate;
            public UInt32 Dis_Item;
            public Byte Dis_CostType;
            public UInt32 Cost_Value;


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
