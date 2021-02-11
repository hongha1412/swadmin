using System;

namespace SWAdmin.TableStruct
{
    public class TBBROACHSETServer : BaseStruct
    {
        public BROACH_SETInfo[] lsData;
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

        public class BROACH_SETInfo : BaseStruct
        {
            public UInt16 Broach_Set_Index;
            public String Broach_Option_Name_Ref_String = "";
            public UInt16 Broach_Set_Buff;


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
