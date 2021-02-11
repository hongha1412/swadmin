using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEBISECTORINFOServer : BaseStruct
    {
        public MODE_BI_SECTOR_INFOInfo[] lsData;
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

        public class MODE_BI_SECTOR_INFOInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte BI_Sector_Type;
            public Byte BI_Sector_Score;
            public Byte BI_Sector_Start_Message_Type;
            public UInt32 BI_Sector_Start_Message;
            public UInt32 BI_Sector_Value;
            public Byte BI_Sector_Value_Type;
            public UInt32 BI_Sector_Value_Massage;
            public Byte BI_Sector_End_Message_Type;
            public UInt32 BI_Sector_End_Message;
            public UInt32 BI_Sector_Bind_Maze;
            public UInt32 BI_Sector_Upgrade_Group;
            public Byte BI_Sector_Upgrade_Qty;
            public Byte BI_Sector_Pocket_Qty;
            public UInt16 BI_Sector_Reward_Item_Qty;
            public UInt32 BI_Sector_Clear_Random_Stat;
            public UInt32 BI_Portal_Buff_Use;


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
