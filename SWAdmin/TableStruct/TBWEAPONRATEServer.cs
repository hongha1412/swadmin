using System;

namespace SWAdmin.TableStruct
{
    public class TBWEAPONRATEServer : BaseStruct
    {
        public WEAPON_RATEInfo[] lsData;
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

        public class WEAPON_RATEInfo : BaseStruct
        {
            public Byte Weapon_Mob_Levelinterval;
            public float Weapon_Mob_Applyrate;


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
