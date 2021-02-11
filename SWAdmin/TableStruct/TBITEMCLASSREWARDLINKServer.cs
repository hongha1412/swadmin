using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMCLASSREWARDLINKServer : BaseStruct
    {
        public ITEM_CLASSREWARD_LINKInfo[] lsData;
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

        public class ITEM_CLASSREWARD_LINKInfo : BaseStruct
        {
            public UInt16 Box_ID;
            public UInt32 PC_A_BoXItem;
            public UInt32 PC_B_BoXItem;
            public UInt32 PC_C_BoXItem;
            public UInt32 PC_D_BoXItem;
            public UInt32 PC_E_BoXItem;
            public UInt32 PC_F_BoXItem;
            public UInt32 PC_G_BoXItem;
            public UInt32 PC_H_BoXItem;


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
