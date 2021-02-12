using System;

namespace SWAdmin.TableStruct
{
    public class TBSOULSTONELEVELUPServer : BaseStruct
    {
        public SOULSTONE_LEVELUPInfo[] lsData;
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

        public class SOULSTONE_LEVELUPInfo : BaseStruct
        {
            public UInt32 SoulStoneLvUp_Index;
            public UInt16 Evolution_Rate;
            public UInt32 Evolution_TargetItemID;
            public UInt16 HiddenSoulStone_Rate;
            public UInt32 HiddenSoulStone_TargetItemID;
            public UInt32 Need_Gold;
            public UInt32 Material_01_ID;
            public UInt32 Material_02_ID;
            public UInt32 Material_03_ID;
            public UInt32 Material_04_ID;
            public UInt32 Material_05_ID;
            public UInt32 Material_01_Count;
            public UInt32 Material_02_Count;
            public UInt32 Material_03_Count;
            public UInt32 Material_04_Count;
            public UInt32 Material_05_Count;


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
