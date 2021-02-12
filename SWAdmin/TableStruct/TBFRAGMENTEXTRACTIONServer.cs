using System;

namespace SWAdmin.TableStruct
{
    public class TBFRAGMENTEXTRACTIONServer : BaseStruct
    {
        public FRAGMENT_EXTRACTIONInfo[] lsData;
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

        public class FRAGMENT_EXTRACTIONInfo : BaseStruct
        {
            public UInt32 Fragment_Extraction_ID;
            public UInt16 Extraction_ExtraBonus_Rate;
            public UInt32 Extraction_ExtraBonus_ItemID;
            public Byte Extraction_ExtraBonus_Count;
            public UInt32 Extraction_BonusItemID;
            public Byte Extraction_BonusItem_Count;
            public UInt32 Extraction_NeedJeny;
            public UInt32 Extraction01_ItemID_01;
            public UInt32 Extraction02_ItemID_02;
            public UInt32 Extraction03_ItemID_03;
            public UInt32 Extraction04_ItemID_04;
            public UInt32 Extraction05_ItemID_05;
            public UInt16 Extraction01_ItemCount_01;
            public UInt16 Extraction02_ItemCount_02;
            public UInt16 Extraction03_ItemCount_03;
            public UInt16 Extraction04_ItemCount_04;
            public UInt16 Extraction05_ItemCount_05;
            public UInt16 Extraction01_Rate_01;
            public UInt16 Extraction02_Rate_01;
            public UInt16 Extraction03_Rate_01;
            public UInt16 Extraction04_Rate_01;
            public UInt16 Extraction05_Rate_01;
            public UInt32 Extraction01_Bonus_Count_01;
            public UInt32 Extraction02_Bonus_Count_01;
            public UInt32 Extraction03_Bonus_Count_01;
            public UInt32 Extraction04_Bonus_Count_01;
            public UInt32 Extraction05_Bonus_Count_01;
            public UInt16 Extraction01_Rate_02;
            public UInt16 Extraction02_Rate_02;
            public UInt16 Extraction03_Rate_02;
            public UInt16 Extraction04_Rate_02;
            public UInt16 Extraction05_Rate_02;
            public UInt16 Extraction01_Rate_03;
            public UInt16 Extraction02_Rate_03;
            public UInt16 Extraction03_Rate_03;
            public UInt16 Extraction04_Rate_03;
            public UInt16 Extraction05_Rate_03;
            public UInt32 Extraction01_Bonus_Count_03;
            public UInt32 Extraction02_Bonus_Count_03;
            public UInt32 Extraction03_Bonus_Count_03;
            public UInt32 Extraction04_Bonus_Count_03;
            public UInt32 Extraction05_Bonus_Count_03;


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
