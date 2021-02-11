using System;

namespace SWAdmin.TableStruct
{
    public class TBPCREWARDSYSTEMServer : BaseStruct
    {
        public PC_REWARD_SYSTEMInfo[] lsData;
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

        public class PC_REWARD_SYSTEMInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte PC_Reward_ISApply;
            public UInt32 Check_Type_Value;
            public Byte Apply_Level;
            public Byte SysMail_ID;
            public Int16 Achieve_Point_1;
            public Int16 Achieve_Point_2;
            public Int16 Achieve_Point_3;
            public Int16 Achieve_Point_4;
            public Int16 Achieve_Point_5;
            public UInt32 Achieve_Reward_1;
            public UInt32 Achieve_Reward_2;
            public UInt32 Achieve_Reward_3;
            public UInt32 Achieve_Reward_4;
            public UInt32 Achieve_Reward_5;


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
