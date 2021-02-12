using System;

namespace SWAdmin.TableStruct
{
    public class TBDIVISIONRANKREWARDServer : BaseStruct
    {
        public DIVISIONRANKREWARDInfo[] lsData;
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

        public class DIVISIONRANKREWARDInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 GroupID;
            public Byte RewardType;
            public Byte GiveType;
            public UInt32 RewardValue_Min;
            public UInt32 RewardValue_Max;
            public UInt32 Drop_Index;


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
