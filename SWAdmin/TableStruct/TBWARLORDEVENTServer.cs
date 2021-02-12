using System;

namespace SWAdmin.TableStruct
{
    public class TBWARLORDEVENTServer : BaseStruct
    {
        public WARLORD_EVENTInfo[] lsData;
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

        public class WARLORD_EVENTInfo : BaseStruct
        {
            public UInt16 ID;
            public String EventFunction_Name_String = "";
            public UInt32 EventDelay_Time;
            public Byte EventDamageDC_Value;
            public UInt32 PostRewardItem_ID;
            public UInt16 BossBox_ID;
            public UInt32 ObjectMonster_ID_01;
            public UInt32 ObjectMonster_ID_02;
            public UInt32 ObjectMonster_ID_03;
            public UInt32 ObjectMonster_ID_04;
            public UInt32 ObjectMonster_ID_05;
            public UInt16 SpawnGroup_ID_01;
            public UInt16 SpawnGroup_ID_02;
            public UInt16 SpawnGroup_ID_03;
            public UInt16 SpawnGroup_ID_04;
            public UInt16 SpawnGroup_ID_05;


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
