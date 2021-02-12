using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEDISTRICT6Server : BaseStruct
    {
        public MODE_DISTRICT6Info[] lsData;
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

        public class MODE_DISTRICT6Info : BaseStruct
        {
            public Byte ID;
            public Byte World_ID;
            public Byte Start_Type;
            public Byte Group;
            public UInt16 Limit_Time;
            public UInt32 Ready_Message;
            public UInt32 Start_Message;
            public UInt32 Success_Message;
            public UInt32 Fail_Message;
            public Byte After_Mode_ID;
            public UInt16 Portal;
            public Byte Summon_Group_Count;
            public UInt32 Summon_Mob_01;
            public UInt32 Summon_Mob_02;
            public UInt32 Summon_Mob_03;
            public UInt32 Summon_Mob_04;
            public UInt32 Summon_Mob_05;
            public UInt32 Summon_Mob_06;
            public UInt32 Summon_Mob_07;
            public UInt32 Summon_Mob_08;
            public UInt32 Summon_Mob_09;
            public UInt32 Summon_Mob_10;
            public UInt16 Summon_Mob_SpawnBox_01;
            public UInt16 Summon_Mob_SpawnBox_02;
            public UInt16 Summon_Mob_SpawnBox_03;
            public UInt16 Summon_Mob_SpawnBox_04;
            public UInt16 Summon_Mob_SpawnBox_05;
            public UInt16 Summon_Mob_SpawnBox_06;
            public UInt16 Summon_Mob_SpawnBox_07;
            public UInt16 Summon_Mob_SpawnBox_08;
            public UInt16 Summon_Mob_SpawnBox_09;
            public UInt16 Summon_Mob_SpawnBox_10;


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
