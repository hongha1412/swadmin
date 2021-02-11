using System;

namespace SWAdmin.TableStruct
{
    public class TBCLASSBATTLEROLEServer : BaseStruct
    {
        public CLASSBATTLE_ROLEInfo[] lsData;
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

        public class CLASSBATTLE_ROLEInfo : BaseStruct
        {
            public UInt16 Index;
            public String Server_Map_String = "";
            public Byte Role_Index;
            public Byte Custom_Role;
            public Byte Req_Min_Lv;
            public Byte Admission_Member;
            public UInt16 Waiting_Time;
            public UInt16 Game_Time;
            public UInt16 Finish_Time;
            public Byte Win_Count;


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
