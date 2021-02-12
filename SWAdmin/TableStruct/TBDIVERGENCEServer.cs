using System;

namespace SWAdmin.TableStruct
{
    public class TBDIVERGENCEServer : BaseStruct
    {
        public DIVERGENCEInfo[] lsData;
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

        public class DIVERGENCEInfo : BaseStruct
        {
            public UInt32 Div_ID;
            public UInt32 Div_GroupID;
            public UInt32 Swap_Div_ID;
            public Byte Div_Level;
            public Byte Div_Max_Level;
            public UInt32 Next_Div_ID;
            public UInt32 Prev_Div_ID;
            public Byte Div_Need_Level;
            public Byte Div_Need_Point;
            public Byte Req_Min_AwakeningGrade;
            public String Skill_NameS_String = "";
            public Byte Div_Option_Type;
            public UInt32 Div_Option_Value;
            public float Div_SubOption_Value;


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
