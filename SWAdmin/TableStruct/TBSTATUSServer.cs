using System;

namespace SWAdmin.TableStruct
{
    public class TBSTATUSServer : BaseStruct
    {
        public STATUSInfo[] lsData;
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

        public class STATUSInfo : BaseStruct
        {
            public UInt16 ID;
            public float STR_First_Value;
            public float STR_UP_Value;
            public float AGI_First_Value;
            public float AGI_UP_Value;
            public float INT_First_Value;
            public float INT_UP_Value;
            public float BAL_First_Value;
            public float BAL_UP_Value;
            public float VIT_First_Value;
            public float VIT_UP_Value;
            public float LUC_First_Value;
            public float LUC_UP_Value;
            public float Con_HP_Grow;
            public float Con_ST_Reg;
            public float Con_SG_Reg;
            public float Con_MSR;
            public float Con_ASR;
            public float Con_PATK_Max;
            public float Con_MATK_Max;
            public float Con_PDEF;
            public float Con_MDEF;
            public float PDPR_First_Value;
            public float MDPR_First_Value;
            public float Con_PAR;
            public float Con_MAR;
            public float Con_PARP;
            public float Con_MARP;
            public float Con_PCP;
            public float Con_MCP;
            public float Con_PCRP;
            public float Con_MCRP;
            public float Con_PCA;
            public float Con_MCA;
            public float Con_PDSR;
            public float Con_MDSR;
            public Byte Res_Burn_Rate;
            public Byte Res_Poision_Rate;
            public Byte Res_Shcok_Rate;
            public Byte Res_Bleed_Rate;
            public Byte Res_Stun_Rate;
            public Byte Res_Paralysis_Rate;
            public Byte Res_Sleep_Rate;
            public Byte Res_Freeze_Rate;
            public Byte Res_Charm_Rate;
            public Byte Res_Confusion_Rate;
            public Byte Res_Silence_Rate;
            public Byte Res_Weak_Rate;
            public UInt16 SG_First_Value;
            public float Con_PvP_Reduce;
            public float Con_PVP_PDPR_Rate;
            public float Con_SADamage_Value;
            public float Con_SG_Absorb_Rate;
            public float Con_HP_First_Value;
            public float Con_ST_First_Value;
            public float Con_PAR_First_Value;
            public float Con_MAR_First_Value;
            public float Con_ADR_Value;
            public float Check_Stat_SA;


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
