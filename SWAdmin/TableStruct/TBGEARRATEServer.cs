using System;

namespace SWAdmin.TableStruct
{
    public class TBGEARRATEServer : BaseStruct
    {
        public GEAR_RATEInfo[] lsData;
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

        public class GEAR_RATEInfo : BaseStruct
        {
            public Byte Gear_Mob_Levelinterval;
            public float Gear_Mob_Applyrate;


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
