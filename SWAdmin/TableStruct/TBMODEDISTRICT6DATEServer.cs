using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEDISTRICT6DATEServer : BaseStruct
    {
        public MODE_DISTRICT6_DATEInfo[] lsData;
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

        public class MODE_DISTRICT6_DATEInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Day_Type;
            public UInt16 Start_Time;
            public UInt16 End_Time;
            public UInt32 Booster_Limit_Time;
            public Byte Appear_Group;
            public UInt16 Clear_Count_01;
            public UInt16 Clear_Count_02;
            public UInt16 Clear_Count_03;
            public UInt16 Clear_Count_04;
            public UInt16 Clear_Count_05;
            public UInt16 Clear_Count_06;
            public UInt32 Clear_Booster_01;
            public UInt32 Clear_Booster_02;
            public UInt32 Clear_Booster_03;
            public UInt32 Clear_Booster_04;
            public UInt32 Clear_Booster_05;
            public UInt32 Clear_Booster_06;


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
