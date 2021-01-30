using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBAkashicRecordsClient : BaseStruct
    {
        public AkashicRecordsInfo[] lsData;
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

        public class AkashicRecordsInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Unknown1;
            public UInt32 Akashic_Group;
            public UInt32 Unknown2;
            public UInt32 Unknown3;
            public Byte Unknown4;
            public UInt16 Array_Index;
            public Byte Type;
            public Byte Cash_Type;
            public Byte Rank;
            public Byte Rare_Point;
            public Byte HiUInt32en_Type;
            public String Unknown5 = "";
            public String Unknown6 = "";
            public String Unknown7 = "";
            public UInt16 Action_Group;
            public UInt16 Unknown8;
            public UInt16 Unknown9;
            // public UInt16 Unknown10;
            public String Unknown10 = "";
            public UInt16 Unknown11;
            public Byte Unknown12;
            public UInt32 Use_Skill_ID;
            public Byte Invoke_Condition;
            public UInt16 Invoke_Rate;
            public UInt32 Skill_ID;
            public UInt32 CoolTime;
            public UInt32 CoolTime_Group;
            public Byte CoolTime_Save;
            public UInt16 CoolTime_Global;
            public Byte Akashic_Limit_Type;
            public UInt32 Akashic_Disassemble;
            public UInt32 EXP_AUInt32;
            public UInt32 Akashic_Combination_Point;
            public UInt32 Gold_AUInt32;
            public UInt32 Make_Need_Exp;
            public Byte Level_Max;
            public UInt32 Lease_Period;
            public UInt32 Lease_Cooltime;
            public UInt32 Gold_Need;
            public UInt32 Gold_Send;

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
