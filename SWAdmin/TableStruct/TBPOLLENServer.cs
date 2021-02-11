using System;

namespace SWAdmin.TableStruct
{
    public class TBPOLLENServer : BaseStruct
    {
        public POLLENInfo[] lsData;
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

        public class POLLENInfo : BaseStruct
        {
            public UInt32 Pollen_Index;
            public UInt32 Pollen_Extend_Item_ID;
            public UInt32 Pollen_Effect_Type;
            public UInt32 Pollen_Effect_Value;
            public UInt32 Pollen_Help_Ani_Time;


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
