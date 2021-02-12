using System;

namespace SWAdmin.TableStruct
{
    public class TBMONSTERWEAPONServer : BaseStruct
    {
        public MONSTER_WEAPONInfo[] lsData;
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

        public class MONSTER_WEAPONInfo : BaseStruct
        {
            public UInt16 ID;
            public String Weapon_Mesh_Change_Name_String = "";
            public UInt32 Weapon_HP;
            public UInt32 Weapon_HP_Value_01;
            public UInt32 Weapon_HP_Value_02;
            public UInt32 Weapon_HP_Value_03;
            public UInt32 Weapon_HP_Value_04;
            public UInt32 Weapon_HP_Value_05;


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
