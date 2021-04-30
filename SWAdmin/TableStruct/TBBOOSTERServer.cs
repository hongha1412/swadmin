using System;

namespace SWAdmin.TableStruct
{
    public class TBBOOSTERServer : BaseStruct
    {
        public BOOSTERInfo[] lsData;
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

        public class BOOSTERInfo : BaseStruct
        {
            public UInt16 Booster_Index;
            public UInt16 Booster_Group;
            public Byte EffectType_01;
            public Byte EffectType_02;
            public Byte EffectType_03;
            public Byte EffectType_04;
            public Byte EffectType_05;
            public Byte EffectType_06;
            public Byte EffectType_07;
            public Byte EffectType_08;
            public Byte ApplyType_01;
            public Byte ApplyType_02;
            public Byte ApplyType_03;
            public Byte ApplyType_04;
            public Byte ApplyType_05;
            public Byte ApplyType_06;
            public Byte ApplyType_07;
            public Byte ApplyType_08;
            public float EffectValue_01;
            public float EffectValue_02;
            public float EffectValue_03;
            public float EffectValue_04;
            public float EffectValue_05;
            public float EffectValue_06;
            public float EffectValue_07;
            public float EffectValue_08;
            public UInt16 EffectString_01;
            public UInt16 EffectString_02;
            public UInt16 EffectString_03;
            public UInt16 EffectString_04;
            public UInt16 EffectString_05;
            public UInt16 EffectString_06;
            public UInt16 EffectString_07;
            public UInt16 EffectString_08;
            public String Booster_Info_String = "";
            public Byte Decrease_Condition;
            public UInt32 Booster_Time;


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
