using System;

namespace SWAdmin.TableStruct
{
    public class TBAURAServer : BaseStruct
    {
        public AURAInfo[] lsData;
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

        public class AURAInfo : BaseStruct
        {
            public UInt16 Aura_Index;
            public Byte Apply_Target;
            public UInt32 Valid_Distance;
            public Byte Check_Type;
            public UInt32 Check_Time;
            public UInt32 Aura_Time;
            public UInt16 Apply_Buff;


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
