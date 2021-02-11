using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMCOSTUMESETServer : BaseStruct
    {
        public ITEM_COSTUMESETInfo[] lsData;
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

        public class ITEM_COSTUMESETInfo : BaseStruct
        {
            public UInt32 Item_CostumeSet_ID;
            public Byte Item_CostumeSet_Max;
            public Byte Need_Gesture_Item1;
            public UInt32 CostumeSet_Gesture1_ID;
            public Byte Need_Gesture_Item2;
            public UInt32 CostumeSet_Gesture2_ID;
            public Byte Need_Gesture_Item3;
            public UInt32 CostumeSet_Gesture3_ID;
            public Byte Need_Equalizer_Item1;
            public UInt32 CostumeSet_Equalizer1_ID;
            public Byte Need_Equalizer_Item2;
            public UInt32 CostumeSet_Equalizer2_ID;
            public Byte Need_Equalizer_Item3;
            public UInt32 CostumeSet_Equalizer3_ID;
            public UInt32 ItemID_1;
            public UInt32 ItemID_2;
            public UInt32 ItemID_3;
            public UInt32 ItemID_4;
            public UInt32 ItemID_5;
            public UInt32 ItemID_6;


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
