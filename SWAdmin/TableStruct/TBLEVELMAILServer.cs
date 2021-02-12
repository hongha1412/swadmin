using System;

namespace SWAdmin.TableStruct
{
    public class TBLEVELMAILServer : BaseStruct
    {
        public LEVEL_MAILInfo[] lsData;
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

        public class LEVEL_MAILInfo : BaseStruct
        {
            public UInt16 LevelMail_ID;
            public String Des_String = "";
            public Byte LevelMail_Post_Type_ID;
            public Byte LevelMail_Condition_Character_Group_ID;
            public Byte LevelMail_Condition_ID;
            public UInt32 Start_Date;
            public Byte Start_Hour;
            public UInt32 End_Date;
            public Byte End_Hour;
            public Byte LevelMail_Character_Type_ID;
            public Byte LevelMail_Value;
            public Byte LevelMail_Type_On_Off;
            public Byte Level_Link_SystemMail_ID;
            public UInt32 LevelMail_ADD_Gold;
            public UInt16 LevelMail_ADD_Count_01;
            public UInt16 LevelMail_ADD_Count_02;
            public UInt16 LevelMail_ADD_Count_03;
            public UInt16 LevelMail_ADD_Count_04;
            public UInt16 LevelMail_ADD_Count_05;


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
