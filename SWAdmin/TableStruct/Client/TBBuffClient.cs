using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBBuffClient : BaseStruct
    {
        public BuffInfo[] lsData;
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

        public class BuffInfo : BaseStruct
        {
            public UInt16 Buff_Index;
            public Byte AllowLocation_Type;
            public Byte System_Type;
            public Byte Buff_Type;
            public UInt16 EffectType_01;
            public UInt16 Buff_Group;
            public Int32 Buff_Success_Rate;
            public Byte Buff_Grade;
            public UInt32 Buff_Time;
            public UInt32 StanBytey_Time;
            public UInt32 DotDelay_Time;
            public Byte Overlap_Type;
            public Byte Overlap_Count;
            public Byte Delete_Type;
            public String SetBuffActionName = "";
            public UInt16 Call_Out_Buff;
            public UInt32 Call_Out_Skill;
            public UInt16 Hit_Call_Buff;
            public UInt16 Change_Buff;
            public Byte EffectType_Status_01;
            public Int32 Option_Value_01;
            public Byte EffectType_Status_02;
            public Int32 Option_Value_02;
            public Byte EffectType_Status_03;
            public Int32 Option_Value_03;
            public UInt16 Unknown2;
            public UInt16 Unknown3;
            public UInt32 Unknown4;
            public UInt32 Unknown5;
            public String Unknown6 = "";
            public UInt16 Unknown7;
            public UInt16 Unknown8;
            public UInt16 Unknown9;
            public Byte Unknown10;
            public Byte Unknown11;

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
