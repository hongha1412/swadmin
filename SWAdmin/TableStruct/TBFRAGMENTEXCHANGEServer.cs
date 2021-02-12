using System;

namespace SWAdmin.TableStruct
{
    public class TBFRAGMENTEXCHANGEServer : BaseStruct
    {
        public FRAGMENT_EXCHANGEInfo[] lsData;
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

        public class FRAGMENT_EXCHANGEInfo : BaseStruct
        {
            public UInt32 S_Exchange_ID;
            public UInt32 S_Get_Item;
            public UInt32 S_GetItem_Count;
            public UInt32 S_Exchange_Count;
            public UInt32 S_Exchange01_Material;
            public UInt32 S_Exchange02_Material;
            public UInt32 S_Exchange03_Material;
            public UInt32 S_Exchange04_Material;
            public UInt32 S_Exchange05_Material;
            public UInt32 S_Exchange06_Material;
            public UInt32 S_Exchange01_MaterialCount;
            public UInt32 S_Exchange02_MaterialCount;
            public UInt32 S_Exchange03_MaterialCount;
            public UInt32 S_Exchange04_MaterialCount;
            public UInt32 S_Exchange05_MaterialCount;
            public UInt32 S_Exchange06_MaterialCount;
            public UInt32 S_Exchange01_Gold;
            public UInt32 S_Exchange02_Gold;
            public UInt32 S_Exchange03_Gold;
            public UInt32 S_Exchange04_Gold;
            public UInt32 S_Exchange05_Gold;
            public UInt32 S_Exchange06_Gold;


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
