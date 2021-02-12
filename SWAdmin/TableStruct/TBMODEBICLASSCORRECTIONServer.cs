using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEBICLASSCORRECTIONServer : BaseStruct
    {
        public MODE_BI_CLASS_CORRECTIONInfo[] lsData;
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

        public class MODE_BI_CLASS_CORRECTIONInfo : BaseStruct
        {
            public Byte ID;
            public float BI_Correction_MaxHP;
            public float BI_Correction_Attack;
            public float BI_Correction_Critical_Rate;
            public float BI_Correction_Speed_Attack;
            public float BI_Correction_Accurate;
            public float BI_Correction_Penetrate;
            public float BI_Correction_MaxStamina;
            public float BI_Correction_Speed_Move;
            public float BI_Correction_Armor;
            public float BI_Correction_Avoid;
            public float BI_Correction_Cooldown;
            public float BI_Correction_Staminaspeed;


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
