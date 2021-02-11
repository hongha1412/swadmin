using System;

namespace SWAdmin.TableStruct
{
    public class TBDISTRICTServer : BaseStruct
    {
        public DISTRICTInfo[] lsData;
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

        public class DISTRICTInfo : BaseStruct
        {
            public Int16 District_ID;
            public UInt32 NeedQuest_ID;
            public String District_FileName_String = "";
            public String District_BatName_String = "";
            public String District_ServerName_String = "";
            public UInt16 District_Time;
            public Int32 District_Start_X;
            public Int32 District_Start_Y;
            public UInt32 District_Size_X;
            public UInt32 District_Size_Y;
            public Byte District_Type;
            public Byte District_Ability;
            public Byte District_Max_People;
            public Byte District_Channel_Count;
            public Byte Arkashic_Use;
            public Byte Force_Use;


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
