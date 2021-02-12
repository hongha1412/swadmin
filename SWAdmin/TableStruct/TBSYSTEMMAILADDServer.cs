using System;

namespace SWAdmin.TableStruct
{
    public class TBSYSTEMMAILADDServer : BaseStruct
    {
        public SYSTEMMAIL_ADDInfo[] lsData;
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

        public class SYSTEMMAIL_ADDInfo : BaseStruct
        {
            public UInt16 AutoMail_ADD_ID;
            public String Des_String = "";
            public Byte MailBox_Type;
            public Byte AutoMail_Type_ID;
            public Byte AutoMail_Type_On_Off;
            public UInt16 AutoMail_Time_Value;
            public Byte Link_SystemMail_ID;
            public UInt32 AutoMail_ADD_Gold;
            public UInt32 AutoMail_ADD_Item_01;
            public UInt32 AutoMail_ADD_Item_02;
            public UInt32 AutoMail_ADD_Item_03;
            public UInt32 AutoMail_ADD_Item_04;
            public UInt32 AutoMail_ADD_Item_05;
            public UInt16 AutoMail_ADD_Count_01;
            public UInt16 AutoMail_ADD_Count_02;
            public UInt16 AutoMail_ADD_Count_03;
            public UInt16 AutoMail_ADD_Count_04;
            public UInt16 AutoMail_ADD_Count_05;


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
